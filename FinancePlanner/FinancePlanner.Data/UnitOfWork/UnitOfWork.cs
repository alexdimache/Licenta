using FinancePlanner.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancePlanner.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FinancePlannerContext _context;

        public UnitOfWork(FinancePlannerContext financePlannerContext)
        {
            _context = financePlannerContext;
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
