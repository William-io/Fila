using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NarniaSystem.ProjetoFila.Domain.Entities.Guiches;
using NarniaSystem.ProjetoFila.Domain.Entities.Guiches.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarniaSystem.ProjetoFila.Infrastructure.Data.EntitiesConfig
{
    public class GuicheConfig : IEntityTypeConfiguration<Guiche>
    {
        public void Configure(EntityTypeBuilder<Guiche> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Status)
                   .HasDefaultValue(StatusGuicheEnum.Fechado);
        }
    }
}
