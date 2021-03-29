using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using System;
using Api.Domain.Interfaces;

namespace Api.Domain.Repository
{
    public interface IEntradaRepository : IRepository<EntradaEntity>
    {
        Task<IEnumerable<EntradaEntity>> GetByMesReferencia(Guid mesReferenciaId);
        Task<IEnumerable<EntradaEntity>> GetNome(string nome);
    }
}
