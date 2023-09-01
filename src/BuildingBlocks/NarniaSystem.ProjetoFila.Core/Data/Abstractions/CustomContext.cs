using Microsoft.EntityFrameworkCore;
using NarniaSystem.ProjetoFila.Core.Data.Interfaces;
using NarniaSystem.ProjetoFila.Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarniaSystem.ProjetoFila.Core.Data.Abstractions
{
    public abstract class CustomContext : DbContext, IUnitOfWork
    {
        public virtual async Task<bool> Commit()
        {
            if (!ChangeTracker.HasChanges())
                return true;

            return (await SaveChangesAsync()) > 0;
        }
    }
}
