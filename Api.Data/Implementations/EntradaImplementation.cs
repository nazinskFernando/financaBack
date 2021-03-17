using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.Context;
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

    }
}
