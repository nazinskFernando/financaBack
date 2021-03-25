using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class PlanejamentosMap : IEntityTypeConfiguration<PlanejamentosEntity>
    {
        public void Configure(EntityTypeBuilder<PlanejamentosEntity> builder)
        {
            builder.ToTable("Planejamentos");
            builder.HasKey(m => m.Id);

        }
    }
}
