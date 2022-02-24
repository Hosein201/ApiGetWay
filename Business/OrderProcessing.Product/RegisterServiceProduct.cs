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

            #endregion

            #region AddTransientService

            #endregion

            #region AddSingletonService

            #endregion

            return services;
        }
    }
}
