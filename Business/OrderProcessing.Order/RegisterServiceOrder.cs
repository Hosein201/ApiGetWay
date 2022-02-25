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

            #endregion

            #region AddTransientService

            #endregion

            #region AddSingletonService

            #endregion

            return services;
        }
    }
}
