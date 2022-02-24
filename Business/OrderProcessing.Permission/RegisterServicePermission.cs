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
            return services;
        }
    }
}
