using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Abstract
{
    public interface IGenericRepository<T> where T: class
    {
        T GetById(int Id);
        IEnumerable<T> GetAll();
        IEnumerable<T> FindT(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
