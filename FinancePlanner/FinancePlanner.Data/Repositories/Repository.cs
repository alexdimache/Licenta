using FinancePlanner.Data.Context;
using FinancePlanner.Entities;

namespace FinancePlanner.Data.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly FinancePlannerContext _financePlannerContext;

        public Repository(FinancePlannerContext financePlannerContext)
        {
            _financePlannerContext = financePlannerContext;
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _financePlannerContext.FindAsync<T>(id);
        }

        public async Task<T> InsertAsync(T entity)
        {
            await _financePlannerContext.AddAsync(entity);

            return entity;
        }

        public async Task<IQueryable<T>> QueryAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
