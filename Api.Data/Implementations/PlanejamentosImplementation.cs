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
    public class PlanejamentosImplementation : BaseRepository<PlanejamentosEntity>, IPlanejamentosRepository
    {
        private DbSet<PlanejamentosEntity> _dataset;

        public PlanejamentosImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<PlanejamentosEntity>();
        }

    }
}
