using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace IdentityServer.UserPermission
{
    public static class CustomUseCheckUserPermissionMiddleware
    {
        public static IApplicationBuilder UseCheckUserPermission(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomCheckUserPermissionMiddleware>();
        }
    }
    public class CustomCheckUserPermissionMiddleware
    {
        private readonly RequestDelegate _next;
        public CustomCheckUserPermissionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {

            try
            {
                await _next(context);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
