using Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace OrderProcessing.Order
{
    public static class RegisterServiceOrder
    {
        /// <summary>
        /// Add Service of OrderProcessing.Order to IServiceCollection
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServiceOrder(this IServiceCollection services)
        {
            #region AddScopedService
            var scopedServices = ServiceCollectionCustome.GetScopedService(typeof(RegisterServiceOrder));

            foreach (var service in scopedServices)
                services.AddScoped(service.InterFaceType, service.ClassType);
            #endregion

            #region AddTransientService
            var transientServices = ServiceCollectionCustome.GetTransientService(typeof(RegisterServiceOrder));

            foreach (var service in transientServices)
                services.AddTransient(service.InterFaceType, service.ClassType);
            #endregion

            #region AddSingletonService
            var singletonServices = ServiceCollectionCustome.GetSingletonService(typeof(RegisterServiceOrder));

            foreach (var service in singletonServices)
                services.AddSingleton(service.InterFaceType, service.ClassType);

            #endregion

            return services;
        }
    }
}
