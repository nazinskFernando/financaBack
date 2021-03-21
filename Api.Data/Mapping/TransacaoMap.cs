using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class TransacaoMap : IEntityTypeConfiguration<TransacaoEntity>
    {
        public void Configure(EntityTypeBuilder<TransacaoEntity> builder)
        {
            builder.ToTable("Transacao");
            builder.HasKey(t => t.Id);

            builder.HasOne(t => t.MesReferencia)
                    .WithMany(m => m.Transacoes);
        }
    }
}
