using Market.DataAccess.Database.Context;
using Market.DataAccess.Database.Interfaces;
using Market.DataAccess.Database.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Market.DataAccess.Database.DI
{
    public static class DependencyRegistrator
    {
        public static IServiceCollection AddDataAccessToDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IGameRepository, GameRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection")),
                ServiceLifetime.Scoped);

            return services;
        }
    }
}
