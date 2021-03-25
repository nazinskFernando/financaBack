using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using System;

namespace Api.Domain.Repository
{
    public interface ISaidaRepository : IRepository<SaidaEntity>
    {
        Task<IEnumerable<SaidaEntity>> GetByMesReferencia(Guid mesReferenciaId);
    }
}
