using System;
using System.Linq;
using System.Linq.Expressions;

namespace WebApi.DB.Repository
{
    public interface IRepository<T>
    {
        void Add(T newEntity);
        void Remove(T entity);
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);

    }
}
