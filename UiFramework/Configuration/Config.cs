using Microsoft.Extensions.Configuration;

namespace UIFramework.Configuration
{
    public static class Config
    {
        static Config()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();
            var section = configuration.GetSection("uiframework");
            Instance = section.Get<UiFrameworkSection>();
        }

        public static UiFrameworkSection Instance { get; set; }
    }
}