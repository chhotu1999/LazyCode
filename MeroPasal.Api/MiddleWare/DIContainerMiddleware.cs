using MeroPasal.DataAccess;

namespace MeroPasal.Api.MiddleWare
{
    public static class DIContainerMiddleware
    {
        public static IServiceCollection AppCoreServices(this IServiceCollection services)
        {
            services.AddScoped<IDataAccessService, DataAccessService>();
            return services;
        }
    }
}
