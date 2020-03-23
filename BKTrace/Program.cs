using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BKTrace.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BKTrace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            //using (var scope = host.Services.CreateScope())
            //{
            //    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            //    context.journalLogs.AddRange(
            //        new Models.JournalLog
            //        {
            //            id = "1",
            //            content = "Quan",
            //            date_time = DateTime.UtcNow
            //        },
            //        new Models.JournalLog
            //        {
            //            id = "2",
            //            content = "Ngoc",
            //            date_time = DateTime.UtcNow
            //        }
            //    );
            //    context.SaveChanges();
            //}
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
