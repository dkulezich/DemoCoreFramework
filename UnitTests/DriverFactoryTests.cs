using NUnit.Framework;
using OpenQA.Selenium;
using UIFramework;
using UIFramework.Configuration;

namespace UnitTests
{
    internal class DriverFactoryTests
    {
        [Test]
        public void Create_IsSuccessful()
        {
            var configuration = new UiFrameworkSection()
            {
                DriverType = "Chrome"
            };

            var driverFactory = new DriverFacotry(configuration);

            Assert.Throws<DriverServiceNotFoundException>(() => driverFactory.Create());
        }
    }
}