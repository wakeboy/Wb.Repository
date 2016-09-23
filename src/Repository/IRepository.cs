using System.Collections.Generic;

namespace Wb.Repository
{
    public interface IRepository<TEntity, TId> where TEntity : Entity<TId>
    {
        /// <summary>
        /// Get an entity by its id
        /// </summary>
        /// <param name="id">Id of the entity</param>
        /// <returns></returns>
        TEntity Get(TId id);

        /// <summary>
        /// Gets a list of all the entities in the database of type TEntity
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Add an entity record to the database
        /// </summary>
        /// <param name="entity"></param>
        void Add(TEntity entity);

        /// <summary>
        /// Add a collection of entities to the database
        /// </summary>
        /// <param name="entities"></param>
        void AddRange(IEnumerable<TEntity> entities);

        /// <summary>
        /// Update an entity in the database
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);

        /// <summary>
        /// Remove an entity from the database
        /// </summary>
        /// <param name="entity">The entity to remove</param>
        void Remove(TEntity entity);

        /// <summary>
        /// Remove a list of entites from the database
        /// </summary>
        /// <param name="entities"></param>
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
