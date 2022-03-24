using Entity.Data;
using Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using OrderProcessing.Infrastructure.Extensions;
using OrderProcessing.Permission;
using Serilog;

namespace OrderProcessing
{
    public class Startup
    {
        public readonly SettingGetWay settingGetWay;
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            settingGetWay = Configuration.GetSection(nameof(SettingGetWay)).Get<SettingGetWay>();
            var builder = new ConfigurationBuilder()
               .SetBasePath(env.ContentRootPath)
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
               .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
               .AddJsonFile("Ocelot.json", optional: false, reloadOnChange: true)
               .AddEnvironmentVariables().Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigDbContext(settingGetWay.ConnectionString);
            services.AddScopedService();
            services.AddOcelot(Configuration);
            services.AddCustomeAuthentication(settingGetWay.JwtSettings);
            services.AddCustomeIdentity(settingGetWay.IdentitySettings);
            services.AddLoggerConfig();
            services.AddControllers()
                .AddNewtonsoftJson(option => option.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddTransientService();
            services.AddServicePermission();
            services.AddServiceData();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseOcelot();
            app.UseSerilogRequestLogging();
        }
    }
}
