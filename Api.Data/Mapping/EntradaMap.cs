using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class EntradaMap : IEntityTypeConfiguration<EntradaEntity>
    {
        public void Configure(EntityTypeBuilder<EntradaEntity> builder)
        {
            builder.ToTable("Entrada");
            builder.HasKey(m => m.Id);

            builder.HasOne(t => t.MesReferencia)
                    .WithMany(m => m.TransacoesEntrada);

            builder.HasOne(t => t.Poupanca)
                    .WithMany(m => m.TransacoesEntrada);

        }
    }
}
