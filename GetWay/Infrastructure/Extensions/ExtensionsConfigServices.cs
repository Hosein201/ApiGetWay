using Entity;
using IdentityServer.Authenticate;
using IdentityServer.UserManager;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace OrderProcessing.Infrastructure.Extensions
{
    public static class ExtensionsConfigServices
    {
        public static void AddScopedService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IJwtService), typeof(JwtService));
        }

        public static void AddTransientService(this IServiceCollection services)
        {
            services.AddTransient(typeof(IAuthenticateService), typeof(AuthenticateService));
        }
    }
}
