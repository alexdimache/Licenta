using FinancePlanner.Data;
using FinancePlanner.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FinancePlanner.Migrations
{
    public class Program
    {
        public static void Main(string[] agrs)
        {
            var hostBuilder = Host.CreateDefaultBuilder(null);
            hostBuilder.ConfigureAppConfiguration(config => config.AddJsonFile("appsettings.json").Build());
            hostBuilder.ConfigureServices((hostContext, services) =>
            {
                services.AddDbContext<FinancePlannerContext>(options => options.UseSqlServer(
                    GetConnectionString(hostContext.Configuration),
                    options =>
                    {
                        options.MigrationsAssembly("FinancePlanner.Migrations");
                        options.CommandTimeout(FinancePlannerDbConfiguration.GetSqlCommandTimeoutInSeconds(hostContext.Configuration));
                    }), 
                    ServiceLifetime.Scoped);
            });

            var host = hostBuilder.Build();

            RunMigrationScripts(host);
        }

        private static string GetConnectionString(IConfiguration configuration)
        {
            return configuration.GetConnectionString("DefaultConnection") ?? throw new Exception("The DB ConnectionString could not be found");
        }

        private static void RunMigrationScripts(IHost host)
        {
            var dbContext = host.Services.GetRequiredService<FinancePlannerContext>();

            var pending = dbContext.Database.GetPendingMigrations();

            Console.WriteLine("The following migrations will be run:");

            foreach (var item in pending)
            {
                Console.WriteLine(item);
            }

            dbContext.Database.Migrate();
        }
    }
}