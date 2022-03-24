using Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace OrderProcessing.Product
{
    public static class RegisterServiceProduct
    {
        /// <summary>
        /// Add Service of OrderProcessing.Product to IServiceCollection
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServiceProduct(this IServiceCollection services)
        {
            #region AddScopedService
            var scopedServices = ServiceCollectionCustome.GetScopedService(typeof(RegisterServiceProduct));

            foreach (var service in scopedServices)
                services.AddScoped(service.InterFaceType, service.ClassType);
            #endregion

            #region AddTransientService
            var transientServices = ServiceCollectionCustome.GetTransientService(typeof(RegisterServiceProduct));

            foreach (var service in transientServices)
                services.AddTransient(service.InterFaceType, service.ClassType);
            #endregion

            #region AddSingletonService
            var singletonServices = ServiceCollectionCustome.GetSingletonService(typeof(RegisterServiceProduct));

            foreach (var service in singletonServices)
                services.AddSingleton(service.InterFaceType, service.ClassType);

            #endregion

            return services;
        }
    }
}
