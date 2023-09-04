using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NarniaSystem.ProjetoFila.Domain.Entities.Categorias;

namespace NarniaSystem.ProjetoFila.Infrastructure.Data.EntitiesConfig
{
    public class CategoriaConfig : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(x => x.Cor)
                   .HasMaxLength(50);
        }
    }
}
