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
using Api.Domain.Dtos.Saida;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.Saida;
using Api.Domain.Repository;
using Api.Domain.Security;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MimeKit;

namespace Api.Service.Services
{
    public class SaidaService : ISaidaService
    {
        private ISaidaRepository _repository;
        public SigningConfigurations _signingConfigurations;
        private readonly IMapper _mapper;
        private IConfiguration _configuration { get; }

        public SaidaService(
            ISaidaRepository repository,
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

        public async Task<SaidaDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<SaidaDto>(entity);
        }

        public async Task<IEnumerable<SaidaDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<SaidaDto>>(listEntity);
        }

        public async Task<SaidaDto> Post(SaidaDto produto)
        {
            var model = _mapper.Map<SaidaModel>(produto);
            var entity = _mapper.Map<SaidaEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<SaidaDto>(result); ;
        }

        public async Task<SaidaDto> Put(SaidaDto produto)
        {
            var model = _mapper.Map<SaidaModel>(produto);
            var entity = _mapper.Map<SaidaEntity>(model);

            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<SaidaDto>(result);
        }
    }
}
