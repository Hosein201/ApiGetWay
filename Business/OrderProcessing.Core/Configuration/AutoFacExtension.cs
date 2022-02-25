using Autofac;
using Autofac.Extensions.DependencyInjection;
using Entity.Data;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using OrderProcessing.Order;
using OrderProcessing.Permission;
using OrderProcessing.Product;
using System;
using System.Linq;

namespace OrderProcessing.Core.Configuration
{
    public static class AutoFacExtension
    {
        public static IServiceProvider BuildServiceProviderWithAutoFac(this IServiceCollection services, AppSetting appSetting)
        {
            ContainerBuilder containerBuilder = new();
            services.ConfigureCors(appSetting.CorsSetting);
            services.ConfigDbContext(appSetting.ConnectionString);
            services.AddLoggerConfig();
            services.AddServiceData();
            services.AddServicePermission();
            services.AddServiceOrder();
            services.AddServiceProduct();
            //services.AddServiceCacheing();

            containerBuilder.Populate(services.Select(s => s).Distinct());
            IContainer container = containerBuilder.Build();

            return new AutofacServiceProvider(container);
        }
    }

    public static class RegisterServiceCore
    {
        public static IServiceCollection AddServiceCore(this IServiceCollection services)
        {
            return services;
        }
    }
}
