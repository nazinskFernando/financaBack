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
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.MesReferencia;
using Api.Domain.Repository;
using Api.Domain.Security;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MimeKit;

namespace Api.Service.Services
{
    public class MesReferenciaService : IMesReferenciaService
    {
        private IMesReferenciaRepository _repository;
        public SigningConfigurations _signingConfigurations;
        private readonly IMapper _mapper;
        private IConfiguration _configuration { get; }

        public MesReferenciaService(
            IMesReferenciaRepository repository,
                            SigningConfigurations signingConfigurations,
                            IMapper mapper,
                            IConfiguration configuration)
        {
            _repository = repository;
            _signingConfigurations = signingConfigurations;
            _configuration = configuration;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<MesReferenciaDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<MesReferenciaDto>(entity);
        }

        public async Task<MesReferenciaDto> GetMesAno(int mes, int ano)
        {
            var entity = await _repository.fintByMesAno(mes, ano);
            return _mapper.Map<MesReferenciaDto>(entity);
        }

        public async Task<IEnumerable<MesReferenciaDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<MesReferenciaDto>>(listEntity);
        }

        public async Task<MesReferenciaDto> Post(MesReferenciaDto produto)
        {
            var model = _mapper.Map<MesReferenciaModel>(produto);
            var entity = _mapper.Map<MesReferenciaEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<MesReferenciaDto>(result); ;
        }

        public async Task<MesReferenciaDto> Put(MesReferenciaDto produto)
        {
            var model = _mapper.Map<MesReferenciaModel>(produto);
            var entity = _mapper.Map<MesReferenciaEntity>(model);

            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<MesReferenciaDto>(result);
        }
    }
}
