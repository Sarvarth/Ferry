using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Ferry
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args, !Environment.UserInteractive);
        }

        public static void BuildWebHost(string[] args, bool isService)
        {
            var pathToContentRoot = Directory.GetCurrentDirectory();

            if (isService)
            {
                pathToContentRoot = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            }
            var config = new ConfigurationBuilder()
                      .SetBasePath(pathToContentRoot)
                      .AddJsonFile("hosting.json", optional: false, reloadOnChange: true)
                      .Build();
            var host = WebHost.CreateDefaultBuilder(args)
                 .UseContentRoot(pathToContentRoot)
                 .UseConfiguration(config)
                 .UseStartup<Startup>()
                 .UseApplicationInsights()
                 .Build();

            if (isService)
            {
                host.RunAsService();
            }
            else
            {
                host.Run();
            }
        }
    }
}
