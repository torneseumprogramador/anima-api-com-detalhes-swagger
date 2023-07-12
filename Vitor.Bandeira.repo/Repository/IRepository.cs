using System.Linq.Expressions;

namespace Vitor.Bandeira.Repository
{
    public interface IRepository<T>
    {
        void Add(T entity);
        IEnumerable<T> Get();
        T? GetById(Expression<Func<T, bool>> predicate);
        void Update(T entity);
        void Remove(T entity);

    }
}