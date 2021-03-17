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
using Api.Domain.Dtos.ProdutoDto;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.Produto;
using Api.Domain.Repository;
using Api.Domain.Security;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MimeKit;

namespace Api.Service.Services
{
    public class ProdutoService : IProdutoService
    {
        private IProdutoRepository _repository;
        public SigningConfigurations _signingConfigurations;
        private readonly IMapper _mapper;
        private IConfiguration _configuration { get; }

        public ProdutoService(IProdutoRepository repository,
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

        public async Task<ProdutoRetornoDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<ProdutoRetornoDto>(entity);
        }

        public async Task<IEnumerable<ProdutoRetornoDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<ProdutoRetornoDto>>(listEntity);
        }

        public async Task<ProdutoRetornoDto> Post(ProdutoDto produto)
        {
            var model = _mapper.Map<ProdutoModel>(produto);
            var entity = _mapper.Map<ProdutoEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<ProdutoRetornoDto>(result); ;
        }

        public async Task<ProdutoRetornoDto> Put(ProdutoDto produto)
        {
            var model = _mapper.Map<ProdutoModel>(produto);
            var entity = _mapper.Map<ProdutoEntity>(model);

            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<ProdutoRetornoDto>(result);
        }
    }
}
