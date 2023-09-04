using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NarniaSystem.ProjetoFila.Domain.Entities.Telas;

namespace NarniaSystem.ProjetoFila.Infrastructure.Data.EntitiesConfig
{
    public class TelaConfig : IEntityTypeConfiguration<Tela>
    {
        public void Configure(EntityTypeBuilder<Tela> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao)
                   .HasMaxLength(100);
        }
    }
}
