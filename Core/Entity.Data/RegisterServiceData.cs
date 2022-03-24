using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Entity.Data
{
    public static class RegisterServiceData
    {
        /// <summary>
        /// Add Service of Entity.Data to IServiceCollection
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServiceData(this IServiceCollection services)
        {
            #region AddScopedService
            var scopedServices = ServiceCollectionCustome.GetScopedService(typeof(RegisterServiceData));

            foreach (var service in scopedServices)
                services.AddScoped(service.InterFaceType, service.ClassType);
            #endregion

            #region AddTransientService
            var transientServices = ServiceCollectionCustome.GetTransientService(typeof(RegisterServiceData));

            foreach (var service in transientServices)
                services.AddTransient(service.InterFaceType, service.ClassType);
            #endregion

            #region AddSingletonService
            var singletonServices = ServiceCollectionCustome.GetSingletonService(typeof(RegisterServiceData));

            foreach (var service in singletonServices)
                services.AddSingleton(service.InterFaceType, service.ClassType);

            #endregion

            return services;
        }

        public static void ConfigDbContext(this IServiceCollection services, ConnectionString connectionString)
        {
            services.AddDbContext<AppDbContext>(option =>
            {
                option.UseSqlServer(connectionString.Value);
            });
        }
    }
}
