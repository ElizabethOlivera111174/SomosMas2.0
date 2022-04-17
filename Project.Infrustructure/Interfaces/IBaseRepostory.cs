using System.Linq.Expressions;
using Project.Domain.Entities;
using Project.Domain.Helpers.Commons;

namespace Project.Infrastucture.Interfaces
{
    public interface IBaseRepository<T> where T : EntityBase
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Insert(T entity);
        Task <Result> Delete(int id);
        Task<Result> Update(T entity);
        bool EntityExists(int id);
        Task<IEnumerable<T>> FindByCondition(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        Task<User> GetByEmail(string email);
        Task<IEnumerable<T>> GetPageAsync(Expression<Func<T, object>> order, int limit, int page);
        Task<int> CountAsync();
    }
}
