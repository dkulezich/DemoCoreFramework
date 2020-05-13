using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using UIFramework.Configuration;

namespace UIFramework.Resolvers
{
    public class ChromeResolver : IDriverResolver
    {
        public string Name => DriverTypes.Chrome;

        public IWebDriver Resolve(UiFrameworkSection configuration)
        {
            return new ChromeDriver(ChromeDriverService.CreateDefaultService(), Capabilities(configuration));
        }

        private ChromeOptions Capabilities(UiFrameworkSection configuration)
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments(new List<string>(configuration.Capabilities.Values));

            return chromeOptions;
        }
    }
}