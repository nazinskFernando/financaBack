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
    public class TransacaoImplementation : BaseRepository<TransacaoEntity>, ITransacaoRepository
    {
        private DbSet<TransacaoEntity> _dataset;

        public TransacaoImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<TransacaoEntity>();
        }

        public async Task<IEnumerable<TransacaoEntity>> FindTransacao(Guid mesReferenciaId, TipoOperacao tipoOperacao)
        {
            IQueryable<TransacaoEntity> query = _dataset;

            query = query.AsNoTracking()
                        .Where(t => t.MesReferenciaId.Equals(mesReferenciaId) && 
                                    t.TipoOperacao.Equals(tipoOperacao));

            return await query.ToArrayAsync();
        }

        public async Task<IEnumerable<TransacaoEntity>> findByIsFixoId(Guid isFixoId)
        {
            IQueryable<TransacaoEntity> query = _dataset;

            query = query.AsNoTracking()
                        .Where(t => t.IsFixId.Equals(isFixoId));

            return await query.ToArrayAsync();
        }

    }
}
