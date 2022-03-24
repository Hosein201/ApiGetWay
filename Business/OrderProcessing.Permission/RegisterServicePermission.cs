using Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace OrderProcessing.Permission
{
    public static class RegisterServicePermission
    {
        /// <summary>
        /// Add Service of OrderProcessing.Permission to IServiceCollection
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServicePermission(this IServiceCollection services)
        {
            #region AddScopedService
            var scopedServices = ServiceCollectionCustome.GetScopedService(typeof(RegisterServicePermission));

            foreach (var service in scopedServices)
                services.AddScoped(service.InterFaceType, service.ClassType);
            #endregion

            #region AddTransientService
            var transientServices = ServiceCollectionCustome.GetTransientService(typeof(RegisterServicePermission));

            foreach (var service in transientServices)
                services.AddTransient(service.InterFaceType, service.ClassType);
            #endregion

            #region AddSingletonService
            var singletonServices = ServiceCollectionCustome.GetSingletonService(typeof(RegisterServicePermission));

            foreach (var service in singletonServices)
                services.AddSingleton(service.InterFaceType, service.ClassType);

            #endregion

            return services;
        }
    }
}
