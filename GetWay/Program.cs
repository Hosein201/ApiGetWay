using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;

namespace OrderProcessing
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                        .WriteTo.Console()
                        .CreateBootstrapLogger();
            try
            {
                CreateHostBuilder(args).Build().Run();

            }
            catch (Exception ex)
            {
                Log.Write(Serilog.Events.LogEventLevel.Verbose, "can not start app orderProcessing", ex);

                throw;
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                       .ConfigureWebHostDefaults(webBuilder =>
                       {
                           webBuilder.UseStartup<Startup>();

                       })
                       .UseSerilog((ctx, lc) => lc
                          .WriteTo.Console()
                          .ReadFrom.Configuration(ctx.Configuration)); 
        }
    }
}