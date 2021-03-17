using System;
using Api.Data.Mapping;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProdutoEntity>(new ProdutoMap().Configure);
             modelBuilder.Entity<EntradaEntity>(new EntradaMap().Configure);
              modelBuilder.Entity<SaidaEntity>(new SaidaMap().Configure);
               modelBuilder.Entity<MesReferenciaEntity>(new MesReferenciaMap().Configure);
                modelBuilder.Entity<TransacaoEntity>(new TransacaoMap().Configure);
        }

    }
}
