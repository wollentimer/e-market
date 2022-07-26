using Market.Business.Services.Interfaces;
using Market.Business.Services.Mappings;
using Market.Business.Services.Services;
using Market.DataAccess.Database.DI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Market.Business.Services.DI
{
    public static class DependencyRegistrator
    {
        public static void AddDataAccessToServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDataAccessToDatabase(configuration);
            RegisterServices(services);
        }

        private static void RegisterServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IGameService, GameService>();
        }
    }
}
