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
            builder.HasKey(u => u.Id);
        }
    }
}
