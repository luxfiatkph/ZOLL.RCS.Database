using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;

namespace ZOLL.RCS.Database.DataContext.Repositories
{
    /// <summary>
    /// This is the generic base class for Repositories associated with tables that have a single-field key
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity representing the table rows</typeparam>
    /// <typeparam name="TKey">The type of the field acting as the table's primary key</typeparam>
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class
    {
        protected TceContext Context { get; }

        public DbSet<TEntity> Entities { get; set; }

        public Repository(TceContext context)
        {
            Context = context;
        }

        public TEntity Get(TKey id)
        {
            return Entities.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Entities.ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Entities.Where(predicate);
        }

        public virtual void Add(TEntity entity)
        {
            Entities.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            Entities.AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            Entities.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Entities.RemoveRange(entities);
        }
    }
}