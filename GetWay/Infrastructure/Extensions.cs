﻿using Entity;
using IdentityServer.Authenticate;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace OrderProcessing.Infrastructure
{
    public static class Extensions
    {
        public static void ConfigDbContext(this IServiceCollection services, ConnectionString connectionString)
        {
            services.AddDbContext<AppDbContext>(option =>
            {
                option.UseSqlServer(connectionString.Value);
            });
        }

        public static void AddScopedService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IJwtService), typeof(JwtService));
        }
    }
}
