using NUnit.Framework;
using OpenQA.Selenium;
using UIExamples.Pages;
using UIFramework;
using UIFramework.Configuration;

namespace UIExamples
{
    public class SearchTests
    {
        public IWebDriver Driver { get; set; }
        public MobileLandingPage LandingPage { get; set; }
        public MobileSearchResultsPage SearchResultsPage { get; set; }

        [SetUp]
        public void Setup()
        {
            var driverFactory = new DriverFacotry(Config.Instance);
            Driver = driverFactory.Create();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void Search_ShowsResutls()
        {
            string brandName = "Audi";

            LandingPage = new MobileLandingPage(Driver);
            LandingPage.SearchForVehicle(brandName);

            SearchResultsPage = new MobileSearchResultsPage(Driver);

            Assert.IsTrue(SearchResultsPage.ResultIsPresent(brandName), $"There are no results for the {brandName} brand");
        }
    }
}