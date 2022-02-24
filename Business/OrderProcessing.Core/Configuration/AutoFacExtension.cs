using Autofac;
using Autofac.Extensions.DependencyInjection;
using Entity.Data;
using Microsoft.Extensions.DependencyInjection;
using OrderProcessing.Order;
using OrderProcessing.Permission;
using System;
using System.Linq;

namespace OrderProcessing.Core.Configuration
{
    public static class AutoFacExtension
    {
        public static IServiceProvider BuildServiceProviderWithAutoFac(this IServiceCollection services)
        {
            ContainerBuilder containerBuilder = new();

            services.AddServiceData();
            services.AddServicePermission();
            services.AddServiceOrder();
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
