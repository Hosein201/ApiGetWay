using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

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

            #endregion

            #region AddTransientService

            #endregion

            #region AddSingletonService

            #endregion

            return services;
        }
    }
}
