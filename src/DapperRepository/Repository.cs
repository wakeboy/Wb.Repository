using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wb.Repository;
using Dapper;

namespace DapperRepository
{
    public abstract class Repository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : DapperEntity<TId>
    {
        private readonly string connectionString;

        public Repository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(TId id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
