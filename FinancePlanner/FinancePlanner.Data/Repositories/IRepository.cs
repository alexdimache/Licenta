using FinancePlanner.Entities;

namespace FinancePlanner.Data.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        Task<T> GetByIdAsync(Guid id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<IQueryable<T>> QueryAsync();

        Task<T> InsertAsync(T entity);

        Task<bool> DeleteAsync(T entity);

        Task<bool> UpdateAsync(T entity);
    }
}
