using System.Collections.Generic;
using Api.Domain.Dtos.ProdutoDto;
using System.Threading.Tasks;
using System;

namespace Api.Domain.Interfaces.Services.Produto
{
    public interface IProdutoService
    {
        Task<ProdutoRetornoDto> Get(Guid id);
        Task<IEnumerable<ProdutoRetornoDto>> GetAll();
        Task<ProdutoRetornoDto> Post(ProdutoDto termo);
        Task<ProdutoRetornoDto> Put(ProdutoDto termo);
        Task<bool> Delete(Guid id);
    }
}
