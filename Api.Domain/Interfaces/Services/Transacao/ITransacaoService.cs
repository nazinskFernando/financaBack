using System.Collections.Generic;
using Api.Domain.Dtos.Transacao;
using System.Threading.Tasks;
using Api.Domain.Entities;
using System;

namespace Api.Domain.Interfaces.Services.Transacao
{
    public interface ITransacaoService
    {
        Task<TransacaoDto> Get(Guid id);
        Task<TransacaoResumoMesDto> GetResumoMes(Guid mesReferenciaId);
        Task<IEnumerable<TransacaoDto>> GetAll();
        Task<IEnumerable<TransacaoDto>> GetAllTransacao(Guid mesReferenciaId, TipoOperacao tipoOperacao);
        Task<TransacaoDto> Post(TransacaoDto termo);
        Task<TransacaoDto> Put(TransacaoDto termo);
        Task<bool> Delete(Guid id);
    }
}
