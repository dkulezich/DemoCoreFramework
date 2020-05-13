using Microsoft.Extensions.Configuration;

namespace APIFramework.Configuration
{
    internal static class Config
    {
        static Config()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();
            var section = configuration.GetSection("apiframework");
            Instance = section.Get<ApiFrameworkSection>();
        }

        public static ApiFrameworkSection Instance { get; set; }
    }
}