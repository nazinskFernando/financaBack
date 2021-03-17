using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class MesReferenciaMap : IEntityTypeConfiguration<MesReferenciaEntity>
    {
        public void Configure(EntityTypeBuilder<MesReferenciaEntity> builder)
        {
            builder.ToTable("MesReferencia");
            builder.HasKey(u => u.Id);
        }
    }
}
