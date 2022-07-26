using Market.Business.Services.DI;
using Market.WebApi.Mapping;

namespace Market.WebApi.Di
{
    public static class DependencyRegistrator
    {
        public static void AddDataAccessToApi(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDataAccessToServices(configuration);
            RegisterServices(services);
        }

        private static void RegisterServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
