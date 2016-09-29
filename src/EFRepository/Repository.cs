using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace Wb.Repository.EFRepository
{
    public abstract class Repository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : EFEntity<TId>, IDisposable
    {
        protected readonly DbContext context;

        public Repository(EFDbContext<TEntity, TId> context)
        {
            this.context = (DbContext)context;
        }

        public virtual void Add(TEntity entity)
        {
            this.context.Set<TEntity>().Add(entity);
            this.context.SaveChanges();
        }

        public virtual void AddRange(IEnumerable<TEntity> entities)
        {
            this.context.Set<TEntity>().AddRange(entities);
            this.context.SaveChanges();
        }
        
        public virtual TEntity Get(TId id)
        {
            return this.context.Set<TEntity>().SingleOrDefault(e => e.Id.Equals(id));
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return this.context.Set<TEntity>().ToList();
        }

        public virtual void Remove(TEntity entity)
        {
            this.context.Set<TEntity>().Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<TEntity> entities)
        {
            this.context.Set<TEntity>().RemoveRange(entities);
        }

        public virtual void Update(TEntity entity)
        {
            this.context.Set<TEntity>().Update(entity);
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose ()
        {
            Dispose(true);
            GC.SuppressFinalize(true);
        }
    }
}
