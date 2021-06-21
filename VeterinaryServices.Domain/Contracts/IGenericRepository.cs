using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace VeterinaryServices.Domain.Contracts
{
    public interface IGenericRepository<T>
    {
        Task<IEnumerable<T>> FindAll();
        Task<T> Find(long id);
        Task<List<T>> FindBy(Expression<Func<T, bool>> predicate);
        void SaveRange(IEnumerable<T> entities);
        void Update(T entity);
        Task Insert(T entity);
    }
}