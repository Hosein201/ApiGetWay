using Infrastructure.Log;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Core;

namespace Infrastructure
{
    /// <summary>
    /// write extention method for all project
    /// </summary>
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services, CorsSetting corsSetting)
        {
            services.AddCors(option =>
            {
                option.AddPolicy(corsSetting.CorsPolicy, builder =>
                {
                    builder.WithOrigins(corsSetting.Origins)
                   .WithMethods(corsSetting.Methods)
                   .WithHeaders(corsSetting.Headers);
                });
            });
        }

        public static void AddSingletonConfig(this IServiceCollection services)
        {
            services.AddSingleton(typeof(ILogger));
            services.AddSingleton(typeof(IAppLogger), typeof(AppLogger));
        }
    }
}