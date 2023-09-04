using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NarniaSystem.ProjetoFila.Domain.Entities.Senhas;

namespace NarniaSystem.ProjetoFila.Infrastructure.Data.EntitiesConfig
{
    public class SenhaConfig : IEntityTypeConfiguration<Senha>
    {
        public void Configure(EntityTypeBuilder<Senha> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Codigo)
                   .HasMaxLength(24);
        }
    }
}
