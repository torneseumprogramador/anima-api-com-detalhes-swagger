using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Vitor.Bandeira.Context;

namespace Vitor.Bandeira.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        public Repository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<T> Get()
        {
            return _context.Set<T>().ToList();
        }

        public T? GetById(Expression<Func<T, bool>> predicate)
        {
            var info = _context.Set<T>().SingleOrDefault(predicate);
            if (info == null) return null;
            return info;
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}