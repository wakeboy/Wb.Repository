using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wb.Repository.EFRepository
{
    public abstract class EFEntity<TId> : Entity<TId>
    {
        public abstract void Map(ModelBuilder modelBuilder);
    }
}
