using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class SaidaMap : IEntityTypeConfiguration<SaidaEntity>
    {
        public void Configure(EntityTypeBuilder<SaidaEntity> builder)
        {
            builder.ToTable("Saida");
            builder.HasKey(m => m.Id);

            builder.HasOne(t => t.MesReferencia)
                    .WithMany(m => m.TransacoesSaida);

            builder.HasOne(t => t.Poupanca)
                    .WithMany(m => m.TransacoesSaida);

        }
    }
}
