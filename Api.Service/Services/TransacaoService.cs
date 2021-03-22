using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using Api.Domain.Models;
using System.Threading.Tasks;
using Api.Domain.Dtos;
using Api.Domain.Dtos.MesReferencia;
using Api.Domain.Dtos.Transacao;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.Transacao;
using Api.Domain.Interfaces.Services.MesReferencia;
using Api.Domain.Repository;
using Api.Domain.Security;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MimeKit;

namespace Api.Service.Services
{
    public class TransacaoService : ITransacaoService
    {
        private ITransacaoRepository _repository;
        private IMesReferenciaService _mesReferenciaService;
        public SigningConfigurations _signingConfigurations;
        private readonly IMapper _mapper;
        private IConfiguration _configuration { get; }

        public TransacaoService(
            ITransacaoRepository repository,
            IMesReferenciaService mesReferenciaService,
                            SigningConfigurations signingConfigurations,
                            IMapper mapper,
                            IConfiguration configuration)
        {
            _repository = repository;
            _signingConfigurations = signingConfigurations;
            _configuration = configuration;
            _mapper = mapper;
           _mesReferenciaService = mesReferenciaService;
        }

        public async Task<bool> Delete(Guid id)
        {
            var isFixo = await _repository.SelectAsync(id);
            if(isFixo.IsFixa){
               return await TransacaoFixaRemover(isFixo.IsFixId);
            } else {
                return await _repository.DeleteAsync(id);
            }            
        }

        public async Task<TransacaoDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<TransacaoDto>(entity);
        }
        public async Task<TransacaoResumoMesDto> GetResumoMes(Guid mesReferenciaId)
        {
            var entradas = await _repository.FindTransacao(mesReferenciaId, TipoOperacao.ENTRADA);
            var saidas = await _repository.FindTransacao(mesReferenciaId, TipoOperacao.SAIDA);

            var countEntrada = entradas.Sum(e => e.Valor);
            var countSaida = saidas.Sum(s => s.Valor);

            var sobra = countEntrada - countSaida;

            var retorno = new TransacaoResumoMesDto();

            retorno.TotalEntrada = countEntrada;
            retorno.TotalSaida = countSaida;
            retorno.Sobra = sobra;

            return retorno;
        }
        public async Task<IEnumerable<TransacaoDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<TransacaoDto>>(listEntity);
        }
        public async Task<IEnumerable<TransacaoDto>> GetAllTransacao(Guid mesReferenciaId, TipoOperacao tipoOperacao)
        {
            var listEntity = await _repository.FindTransacao(mesReferenciaId, tipoOperacao);
            return _mapper.Map<IEnumerable<TransacaoDto>>(listEntity);
        }

        public async Task<TransacaoDto> Post(TransacaoDto produto)
        {
            var model = _mapper.Map<TransacaoModel>(produto);
            var entity = _mapper.Map<TransacaoEntity>(model);
            if(entity.IsFixa){
                entity.Id = entity.IsFixId = Guid.NewGuid();
            }
            var result = await _repository.InsertAsync(entity);
            if(entity.IsFixa){
                await TransacaoFixa(result, false);
            }
           
            // se for fixo criar nos demais meses a frente

            return _mapper.Map<TransacaoDto>(result);            
        }

        public async Task<TransacaoDto> Put(TransacaoDto transacao)
        {
            var model = _mapper.Map<TransacaoModel>(transacao);
            var entity = _mapper.Map<TransacaoEntity>(model);  

            // var valor = await _repository.SelectAsync(entity.Id);
            // var isFixo = valor.IsFixa;
            var result = await _repository.UpdateAsync(entity);
           
        //    if(isFixo && !entity.IsFixa){
        //        await TransacaoFixaRemover(valor.IsFixId);
        //    } else {
        //        await TransacaoFixa(result, true);
        //    }            
            
            return _mapper.Map<TransacaoDto>(result);
        }

        public async Task<bool> TransacaoFixa(TransacaoEntity transacao, bool isEdit){

            var mesReferenciaAux = new MesReferenciaDto();
            var mesReferencia = await _mesReferenciaService.Get(transacao.MesReferenciaId);
            if(isEdit){
                do
                {
                    if(mesReferencia.Mes == 12){
                        mesReferencia.Mes = 1;
                        mesReferencia.Ano +=1;
                    } else {
                        mesReferencia.Mes +=1;
                    }                    

                    mesReferenciaAux   = await _mesReferenciaService.GetMesAno(mesReferencia.Mes, mesReferencia.Ano);
                    if(mesReferenciaAux != null){   
                        if(transacao.IsFixId == new Guid()){
                            transacao.IsFixId = transacao.Id;
                             await _repository.UpdateAsync(transacao);
                        }                 
                        var transacaoAux = await _repository.findByIsFixoId(transacao.IsFixId);
                        transacao.MesReferenciaId = mesReferenciaAux.Id;
                        if(transacaoAux != null){
                            await _repository.UpdateAsync(transacao);
                        } else {
                            transacao.IsFixId = transacao.Id;
                            transacao.Id = new Guid();
                            await _repository.InsertAsync(transacao);
                        }   
                    }  
                } while (mesReferenciaAux != null);

                // se for virar fixo, buscar em todos os mesesReferencia e atualizar(se não existir deve criar)
                //  * se for for fixo e deixar de ser, buscar em todos os mesesReferencia e deletar 
            } else {
                var IsFixIdAux = transacao.Id;
                
               do
                {
                    if(mesReferencia.Mes == 12){
                        mesReferencia.Mes = 1;
                        mesReferencia.Ano +=1;
                    } else {
                        mesReferencia.Mes +=1;
                    }                

                    mesReferenciaAux = await _mesReferenciaService.GetMesAno(mesReferencia.Mes, mesReferencia.Ano);
                    if(mesReferenciaAux != null){
                        transacao.IsFixId = IsFixIdAux;
                        transacao.Id = new Guid();
                        transacao.MesReferenciaId = mesReferenciaAux.Id;       
                        await _repository.InsertAsync(transacao); 
                    }
                                           
                } while (mesReferenciaAux != null);
            }
            
            return true;
        }

         public async Task<bool> TransacaoFixaRemover(Guid IsFixId){

            var transacoes = await _repository.findByIsFixoId(IsFixId);

            if(transacoes != null){
                foreach (var t in transacoes)
                {
                    await _repository.DeleteAsync(t.Id);
                    
                }
            }
            
            return true;
        }

    }
}
