using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using VertmarketHttpClient;
using Microsoft.Extensions.Configuration;


namespace VertmarketsMagazine
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();            

            var fooApp = serviceProvider.GetService<Processor>();
            Console.WriteLine($"Start Process.....");
            Task<string> resp = Task.Run(() => fooApp.GetAnswersResult());
            Console.WriteLine($"Result: {resp.Result}");
            Console.Read();
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            
            services.AddLogging(configure =>
            {
                configure.AddConsole();
            })                
                .AddTransient<Processor>()
                .AddSingleton<IHttpClientWrapper, HttpClientWrapper>();

            
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", false)
                .Build();

           
            services.AddSingleton(configuration);

            services.AddHttpClient("HttpClient");
        }
    }
}
