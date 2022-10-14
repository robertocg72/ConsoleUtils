namespace ConsoleUtils
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            //Create service collection
            var services = new ServiceCollection();
            ConfigureServices(services);

            //Create service provider
            var serviceProvider = services.BuildServiceProvider();

            //Run main application
            await serviceProvider.GetService<Main>().Run(args);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            //Build config
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .AddEnvironmentVariables()
                .AddUserSecrets<Main>()
                .Build();

            services.AddOptions();
            services.Configure<ApplicationSettings>(configuration.GetSection("ApplicationSettings"));

            //Add main application
            services.AddTransient<Main>();
        }
    }
}
