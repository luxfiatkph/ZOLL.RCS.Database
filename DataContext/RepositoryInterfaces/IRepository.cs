using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;

namespace ZOLL.RCS.Database.DataContext.RepositoryInterfaces
{
    public interface IRepository<TEntity, in TKey> where TEntity : class
    {
        TEntity Get(TKey id);

        DbSet<TEntity> Entities { get; set; }

        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
