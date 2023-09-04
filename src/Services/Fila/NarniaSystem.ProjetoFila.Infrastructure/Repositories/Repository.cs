using Microsoft.EntityFrameworkCore;
using NarniaSystem.ProjetoFila.Core.Data.Interfaces;
using NarniaSystem.ProjetoFila.Core.Domain.Abstractions;
using NarniaSystem.ProjetoFila.Core.Domain.Interfaces;
using NarniaSystem.ProjetoFila.Infrastructure.Data;
using System.Linq.Expressions;

namespace NarniaSystem.ProjetoFila.Infrastructure.Repositories
{
    public abstract class Repository<TEntity> where TEntity : Entity, IAggregateRoot
    {
        public IUnitOfWork UnitOfWork => Context;

        protected FilaDbContext Context { get; set; }

        public Repository(FilaDbContext context) =>
            Context = context;

        public Task<TEntity?> GetByIdAsync(Guid id)
        {
            return Context.Set<TEntity>()
            .FirstOrDefaultAsync(entity => entity.Id == id);
        }

        public Task<List<TEntity>> GetAllAsync()
        {
            return Context.Set<TEntity>()
            .ToListAsync();
        }

        public Task<List<TEntity>> WhereAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>()
                .Where(predicate).ToListAsync();
        }

        public Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>()
                .FirstOrDefaultAsync(predicate);
        }

        public Repository<TEntity> Include(params string[] includes)
        {
            foreach (var include in includes)
                Context.Set<TEntity>()
                    .Include(include);
            return this;
        }

        public void Insert(params TEntity[] entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        public void Update(params TEntity[] entities)
        {
            Context.Set<TEntity>().UpdateRange(entities);
        }

        public void Delete(params TEntity[] entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }
    }
}
