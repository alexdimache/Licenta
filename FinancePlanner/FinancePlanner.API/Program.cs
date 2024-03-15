using AutoMapper;
using FinancePlanner.API.AutoMapper;
using FinancePlanner.Data.Repositories;
using FinancePlanner.Services.UserService;

namespace FinancePlanner.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var mapperConfiguration = new MapperConfiguration(mapping =>
                {
                    mapping.AddProfile(new AutoMapperProfile());
                });
            mapperConfiguration.AssertConfigurationIsValid();

            var mapper = mapperConfiguration.CreateMapper();

            builder.Services.AddSingleton(mapper);

            RegisterDependencyInjection(builder.Services);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }

        private static void RegisterDependencyInjection(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}