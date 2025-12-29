using System.Linq.Expressions;
using UserLogin.DTO;

namespace UserLogin.Repo_Pattern
{
    public interface IGenericRepository<T> where T : class
    {

        Task <IEnumerable<T>> GetAllAsync();
        Task AddAsync(T Entity);
       
        Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate);
    }
}
