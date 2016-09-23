using System;

namespace Wb.Repository
{
    public abstract class BaseEntity { }

    public abstract class Entity<TId> : BaseEntity, IDisposable
    {
        public TId Id { get; set; }

        public virtual void Dispose()
        {
        }
    }
}
