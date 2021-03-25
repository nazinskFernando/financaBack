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
using Api.Domain.Dtos.Planejamentos;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.Planejamentos;
using Api.Domain.Repository;
using Api.Domain.Security;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MimeKit;

namespace Api.Service.Services
{
    public class PlanejamentosService : IPlanejamentosService
    {
        private IPlanejamentosRepository _repository;
        public SigningConfigurations _signingConfigurations;
        private readonly IMapper _mapper;
        private IConfiguration _configuration { get; }

        public PlanejamentosService(
            IPlanejamentosRepository repository,
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

        public async Task<PlanejamentosDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<PlanejamentosDto>(entity);
        }

        public async Task<IEnumerable<PlanejamentosDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<PlanejamentosDto>>(listEntity);
        }

        public async Task<PlanejamentosDto> Post(PlanejamentosDto objeto)
        {
            var model = _mapper.Map<PlanejamentosModel>(objeto);
            var entity = _mapper.Map<PlanejamentosEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<PlanejamentosDto>(result); ;
        }

        public async Task<PlanejamentosDto> Put(PlanejamentosDto objeto)
        {
            var model = _mapper.Map<PlanejamentosModel>(objeto);
            var entity = _mapper.Map<PlanejamentosEntity>(model);

            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<PlanejamentosDto>(result);
        }
    }
}
