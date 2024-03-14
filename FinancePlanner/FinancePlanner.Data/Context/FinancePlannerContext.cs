using FinancePlanner.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace FinancePlanner.Data.Context
{
    public class FinancePlannerContext : DbContext
    {
        public FinancePlannerContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
