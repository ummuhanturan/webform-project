using P.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace P.DataAccess.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DatabaseContext _databaseContext;

        public GenericRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public void Add(T entity)
        {
            try
            {
                _databaseContext.Set<T>().Add(entity);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.InnerException); 
            }
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _databaseContext.Set<T>().AddRange(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _databaseContext.Set<T>().Where(expression);
        }

        public T FindSingle(Expression<Func<T, bool>> expression)
        {
            return _databaseContext.Set<T>().Where(expression).SingleOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return _databaseContext.Set<T>().ToList();
        }

        public T GetById(int Id)
        {
            return _databaseContext.Set<T>().Find(Id);
        }

        public void Remove(T entity)
        {
            _databaseContext.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _databaseContext.Set<T>().RemoveRange(entities);
        }

    }
}
