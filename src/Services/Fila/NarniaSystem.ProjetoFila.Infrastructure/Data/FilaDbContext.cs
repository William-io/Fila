using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NarniaSystem.ProjetoFila.Core.Data.Interfaces;
using NarniaSystem.ProjetoFila.Core.Domain.Abstractions;
using NarniaSystem.ProjetoFila.Domain.Entities.Senhas;
using System.Reflection.Emit;

namespace NarniaSystem.ProjetoFila.Infrastructure.Data
{
    public class FilaDbContext : DbContext, IUnitOfWork
    {
        public FilaDbContext(DbContextOptions<FilaDbContext> options) : base(options){}

        public DbSet<Senha> Senhas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigDefalutValues(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FilaDbContext).Assembly);
        }

        private void ConfigDefalutValues(ModelBuilder modelBuilder)
        {
            var getPropreties = modelBuilder.Model.GetEntityTypes().SelectMany(x => x.GetProperties());

            foreach (var prop in getPropreties.Where(x => x.ClrType == typeof(string)))
            {
                prop.SetColumnType("VARCHAR(100)");
            }

            foreach (var prop in getPropreties.Where(x => x.ClrType == typeof(DateTime)))
            {
                prop.SetColumnType("DATETIME");
            }

            foreach (var prop in getPropreties.Where(x => x.ClrType == typeof(decimal) || x.ClrType == typeof(double)))
            {
                prop.SetColumnType("DECIMAL(6,2)");
            }
        }

        public virtual async Task<bool> Commit()
        {
            if (!ChangeTracker.HasChanges())
                return true;

            MapChanges(ChangeTracker);

            return (await SaveChangesAsync()) > 0;
        }


        private void MapChanges(ChangeTracker changeTracker)
        {
            var entities = changeTracker.Entries<Entity>();

            foreach (var entity in entities)
            {
                switch (entity.State)
                {
                    case EntityState.Detached:
                        break;
                    case EntityState.Unchanged:
                        break;
                    case EntityState.Deleted:
                        break;
                    case EntityState.Modified:
                        entity.Entity.AlteredAt = DateTime.Now;
                        break;
                    case EntityState.Added:
                        entity.Entity.CreatedAt = DateTime.Now;
                        entity.Entity.AlteredAt = DateTime.MinValue;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
