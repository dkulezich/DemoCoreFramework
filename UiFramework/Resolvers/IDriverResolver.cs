using OpenQA.Selenium;
using UIFramework.Configuration;

namespace UIFramework.Resolvers
{
    public interface IDriverResolver
    {
        string Name { get; }

        IWebDriver Resolve(UiFrameworkSection configuration);
    }
}