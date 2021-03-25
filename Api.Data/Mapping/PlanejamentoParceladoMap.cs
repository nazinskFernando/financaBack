using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class PlanejamentoParceladoMap : IEntityTypeConfiguration<PlanejamentoParceladoEntity>
    {
        public void Configure(EntityTypeBuilder<PlanejamentoParceladoEntity> builder)
        {
            builder.ToTable("PlanejamentoParcelado");
            builder.HasKey(m => m.Id);

            builder.HasOne(pp => pp.Planejamentos)
                    .WithMany(p => p.PlanejamentoParcelados);

            builder.HasOne(pp => pp.MesReferencia)
                    .WithMany(p => p.PlanejamentoParcelados);
        }
    }
}
