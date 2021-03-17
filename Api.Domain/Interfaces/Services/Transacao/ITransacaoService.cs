using System.Collections.Generic;
using Api.Domain.Dtos.Transacao;
using System.Threading.Tasks;
using System;

namespace Api.Domain.Interfaces.Services.Transacao
{
    public interface ITransacaoService
    {
        Task<TransacaoDto> Get(Guid id);
        Task<IEnumerable<TransacaoDto>> GetAll();
        Task<TransacaoDto> Post(TransacaoDto termo);
        Task<TransacaoDto> Put(TransacaoDto termo);
        Task<bool> Delete(Guid id);
    }
}
