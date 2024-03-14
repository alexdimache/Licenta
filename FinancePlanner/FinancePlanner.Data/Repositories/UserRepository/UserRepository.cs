using FinancePlanner.Data.Context;

namespace FinancePlanner.Data.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly FinancePlannerContext _financePlannerContext;

        public UserRepository(FinancePlannerContext financePlannerContext)
        {
            _financePlannerContext = financePlannerContext;
        }
    }
}
