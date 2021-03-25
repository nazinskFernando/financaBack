using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class PoupancaMap : IEntityTypeConfiguration<PoupancaEntity>
    {
        public void Configure(EntityTypeBuilder<PoupancaEntity> builder)
        {
            builder.ToTable("Poupanca");
            builder.HasKey(m => m.Id);

        }
    }
}
