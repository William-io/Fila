using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NarniaSystem.ProjetoFila.Domain.Entities.Filas;

namespace NarniaSystem.ProjetoFila.Infrastructure.Data.EntitiesConfig
{
    public class FilaConfig : IEntityTypeConfiguration<Fila>
    {
        public void Configure(EntityTypeBuilder<Fila> builder)
        {

            builder.HasKey(x => x.Id);
        }
    }
}
