using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using UIFramework.Configuration;
using UIFramework.Resolvers;

namespace UIFramework
{
    public class DriverFacotry
    {
        private readonly UiFrameworkSection config;

        public List<IDriverResolver> Resolvers { get; set; } = new List<IDriverResolver>
        {
            new ChromeResolver()
        };

        public DriverFacotry(UiFrameworkSection config)
        {
            this.config = config;
        }

        public IWebDriver Create()
        {
            var driverType = config.DriverType;
            var resolver = Resolvers.First(r => r.Name == driverType);

            return resolver.Resolve(config);
        }
    }
}