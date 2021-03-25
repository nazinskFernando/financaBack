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
using Api.Domain.Dtos.Poupanca;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.Poupanca;
using Api.Domain.Repository;
using Api.Domain.Security;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MimeKit;

namespace Api.Service.Services
{
    public class PoupancaService : IPoupancaService
    {
        private IPoupancaRepository _repository;
        public SigningConfigurations _signingConfigurations;
        private readonly IMapper _mapper;
        private IConfiguration _configuration { get; }

        public PoupancaService(
            IPoupancaRepository repository,
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

        public async Task<PoupancaDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<PoupancaDto>(entity);
        }

        public async Task<IEnumerable<PoupancaDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<PoupancaDto>>(listEntity);
        }

        public async Task<PoupancaDto> Post(PoupancaDto objeto)
        {
            var model = _mapper.Map<PoupancaModel>(objeto);
            var entity = _mapper.Map<PoupancaEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<PoupancaDto>(result); ;
        }

        public async Task<PoupancaDto> Put(PoupancaDto objeto)
        {
            var model = _mapper.Map<PoupancaModel>(objeto);
            var entity = _mapper.Map<PoupancaEntity>(model);

            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<PoupancaDto>(result);
        }
    }
}
