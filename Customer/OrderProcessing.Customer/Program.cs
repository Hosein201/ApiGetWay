using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;

namespace OrderProcessing.Customer
{
    public class Program
    {
        public static ILogger logger;

        public static void Main(string[] args)
        {
            logger = new LoggerConfiguration().CreateLogger();
            try
            {
                CreateHostBuilder(args).Build().Run();

            }
            catch (Exception ex)
            {
                logger.Write(Serilog.Events.LogEventLevel.Verbose, "can not start app customer", ex);

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
                           webBuilder.UseStartup<Startup>()
                            .UseSerilog(logger);
                       });
        }
    }
}
