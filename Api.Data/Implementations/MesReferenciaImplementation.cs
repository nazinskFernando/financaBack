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
    public class MesReferenciaImplementation : BaseRepository<MesReferenciaEntity>, IMesReferenciaRepository
    {
        private DbSet<MesReferenciaEntity> _dataset;

        public MesReferenciaImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<MesReferenciaEntity>();
        }

    }
}
