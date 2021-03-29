using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.Context;
using System;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class EntradaImplementation : BaseRepository<EntradaEntity>, IEntradaRepository
    {
        private DbSet<EntradaEntity> _dataset;

        public EntradaImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<EntradaEntity>();
        }

        public async Task<IEnumerable<EntradaEntity>> GetByMesReferencia(Guid mesReferenciaId)
        {
            IQueryable<EntradaEntity> query = _dataset;

            query = query.AsNoTracking()
                        .Where(t => t.MesReferenciaId.Equals(mesReferenciaId));

            return await query.ToArrayAsync();
        }

        public async Task<IEnumerable<EntradaEntity>> GetNome(string nome)
        {
            IQueryable<EntradaEntity> query = _dataset;

            query = query.AsNoTracking()
                        .Where(t => t.Nome.Equals(nome));

            return await query.ToArrayAsync();
        }

    }
}
