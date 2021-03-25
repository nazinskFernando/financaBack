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
    public class PlanejamentoParceladoImplementation : BaseRepository<PlanejamentoParceladoEntity>, IPlanejamentoParceladoRepository
    {
        private DbSet<PlanejamentoParceladoEntity> _dataset;

        public PlanejamentoParceladoImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<PlanejamentoParceladoEntity>();
        }

    }
}
