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
using Api.Domain.Dtos.Entrada;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.Entrada;
using Api.Domain.Interfaces.Services.MesReferencia;
using Api.Domain.Repository;
using Api.Domain.Security;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MimeKit;

namespace Api.Service.Services
{
    public class EntradaService : IEntradaService
    {
        private IEntradaRepository _repository;
        public SigningConfigurations _signingConfigurations;
        private readonly IMapper _mapper;
        private IMesReferenciaService _mesReferenciaService;
        private IConfiguration _configuration { get; }

        public EntradaService(
            IEntradaRepository repository,
                            SigningConfigurations signingConfigurations,
                            IMapper mapper,
                            IMesReferenciaService mesReferenciaService,
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
            return await _repository.DeleteAsync(id);
        }

        public async Task<EntradaDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<EntradaDto>(entity);
        }

        public async Task<IEnumerable<EntradaDto>> GetByMesReferencia(Guid mesReferenciaId)
        {
            var listEntity = await _repository.GetByMesReferencia(mesReferenciaId);
            return _mapper.Map<IEnumerable<EntradaDto>>(listEntity);
        }

        public async Task<IEnumerable<EntradaDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<EntradaDto>>(listEntity);
        }

        public async Task<EntradaDto> Post(EntradaDto objeto)
        {
            var model = _mapper.Map<EntradaModel>(objeto);
            var entity = _mapper.Map<EntradaEntity>(model);
            if(objeto.PoupancaId == null){
                entity.PoupancaId = null;
            }
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<EntradaDto>(result); ;
        }

        public async Task<EntradaDto> Put(EntradaDto objeto)
        {
            var model = _mapper.Map<EntradaModel>(objeto);
            var entity = _mapper.Map<EntradaEntity>(model);

            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<EntradaDto>(result);
        }
    }
}
