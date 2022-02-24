using Microsoft.Extensions.DependencyInjection;

namespace OrderProcessing.Cacheing
{
    public static class RegisterServiceCacheing
    {
        /// <summary>
        /// Add Service of OrderProcessing.Cacheing to IServiceCollection
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServiceCacheing(this IServiceCollection services)
        {
            return services;
        }
    }
}
