using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Api.Domain.Entities;
using Api.Domain.Interfaces;

namespace Api.Domain.Repository
{
    public interface ITransacaoRepository : IRepository<TransacaoEntity>
    {
        Task<IEnumerable<TransacaoEntity>> FindTransacao(Guid mesReferenciaId, TipoOperacao tipoOperacao);
        Task<IEnumerable<TransacaoEntity>> findByIsFixoId(Guid isFixoId);
    }
}
