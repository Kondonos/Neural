using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Neural
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Neural network";

            var config=new  ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.json")
                .Build();

            var services=new ServiceCollection()
                .AddOptions()

                .AddSingleton(new LoggerFactory().AddConsole(config.GetSection("Logging:Console")))
                .AddLogging()

        }
    }
}
