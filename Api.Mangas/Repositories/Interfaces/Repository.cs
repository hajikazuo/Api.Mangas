using Api.Mangas.Entities;
using System.Linq.Expressions;

namespace Api.Mangas.Repositories.Interfaces
{
    public interface IRepository<T> : IDisposable where T : Entity
    {
        Task AddAsync(T entity);
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int? id);
        Task UpdateAsync(T entity);
        Task RemoveAsync(int? id);

        Task<IEnumerable<T>>
            SearchAsync(Expression<Func<T, bool>> predicate);
    }

}
