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
    public class SaidaImplementation : BaseRepository<SaidaEntity>, ISaidaRepository
    {
        private DbSet<SaidaEntity> _dataset;

        public SaidaImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<SaidaEntity>();
        }

        public async Task<IEnumerable<SaidaEntity>> GetByMesReferencia(Guid mesReferenciaId)
        {
            IQueryable<SaidaEntity> query = _dataset;

            query = query.AsNoTracking()
                        .Where(t => t.MesReferenciaId.Equals(mesReferenciaId));

            return await query.ToArrayAsync();
        }

        public async Task<IEnumerable<SaidaEntity>> GetNome(string nome)
        {
            IQueryable<SaidaEntity> query = _dataset;

            query = query.AsNoTracking()
                        .Where(t => t.Nome.Equals(nome));

            return await query.ToArrayAsync();
        }

    }
}
