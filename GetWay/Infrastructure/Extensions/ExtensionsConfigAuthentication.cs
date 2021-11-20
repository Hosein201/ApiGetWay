using Entity.Models;
using Infrastructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing.Infrastructure.Extensions
{
    public static class ExtensionsConfigAuthentication
    {
        public static void AddCustomeAuthentication(this IServiceCollection services, JwtSettings jwtSettings)
        {
            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(option =>
            {
                var secretkey = Encoding.UTF8.GetBytes(jwtSettings.SecretKey);
                var encryptionkey = Encoding.UTF8.GetBytes(jwtSettings.Encryptkey);

                TokenValidationParameters tokenValidationParameters = new()
                {
                    ClockSkew = TimeSpan.Zero,
                    RequireSignedTokens = true,

                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(secretkey),
                    RequireExpirationTime = true,

                    ValidateLifetime = true,

                    ValidateAudience = true,
                    ValidAudience = jwtSettings.Audience,

                    ValidateIssuer = true,
                    ValidIssuer = jwtSettings.Issuer,

                    TokenDecryptionKey = new SymmetricSecurityKey(encryptionkey)
                };
                option.RequireHttpsMetadata = false;
                option.SaveToken = true;
                option.TokenValidationParameters = tokenValidationParameters;

                option.Events = new JwtBearerEvents()
                {
                    OnAuthenticationFailed = context =>
                    {
                        if (context.Exception is not null)
                            throw new Exception(context.Exception.Message, context.Exception);
                        return Task.CompletedTask;
                    },
                    OnChallenge = context =>
                    {
                        if (context.AuthenticateFailure is not null)
                            throw new Exception("Authenticate failure.", context.AuthenticateFailure);
                        if (!string.IsNullOrEmpty(context.Error) || !string.IsNullOrEmpty(context.ErrorDescription))
                            throw new Exception($"You are unauthorized to access this resource. and {context.Error} and {context.ErrorDescription}");
                        return Task.CompletedTask;
                    },
                    OnTokenValidated = async context =>
                    {
                        var signInManager = context.HttpContext.RequestServices.GetRequiredService<SignInManager<User>>();
                        var userManager = context.HttpContext.RequestServices.GetRequiredService<UserManager<User>>();

                        var claimsIdentity = context.Principal.Identity as ClaimsIdentity;
                        if (claimsIdentity.Claims?.Any() is not true)
                            context.Fail("This token has no claims.");

                        var securityStamp = claimsIdentity.FindFirst(new ClaimsIdentityOptions().SecurityStampClaimType);
                        if (securityStamp.Value is not null)
                            context.Fail("This token has no secuirty stamp");


                        //Find user and token from database and perform your custom validation
                        var userName = claimsIdentity.FindFirst(new ClaimsIdentityOptions().UserNameClaimType).Value;
                        var user = await userManager.FindByNameAsync(userName);

                        if (Guid.Parse(user.SecurityStamp) != Guid.Parse(securityStamp.Value))
                            context.Fail("Token secuirty stamp is not valid.");

                        var validatedUser = await signInManager.ValidateSecurityStampAsync(context.Principal);
                        if (validatedUser is null)
                            context.Fail("Token secuirty stamp is not valid.");

                        if (!user.IsActive)
                            context.Fail("User is not active");
                    }
                };
            });
        }
    }
}
