using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using UIFramework.BasePage;
using UIFramework.Configuration;
using UIFramework.Extentions;

namespace UIExamples.Pages
{
    public class MobileLandingPage : BasePage
    {
        public MobileLandingPage(IWebDriver driver) : base(driver)
        {
            driver.Navigate().GoToUrl("https://www.mobile.bg/");
        }

        private By BrandSelector = By.Name("marka");
        public IWebElement Brand => Driver.FindElement(BrandSelector);

        public IWebElement Search => Driver.FindElement(By.Id("button2"));

        public void SelectBrand(string brandName)
        {
            Driver.WaitToExist(BrandSelector, Config.Instance.DefaultWait);
            SelectElement brandSelect = new SelectElement(Brand);

            brandSelect.SelectByValue(brandName);
        }

        public void SearchForVehicle()
        {
            Search.Click();
        }

        public void SearchForVehicle(string brandName)
        {
            SelectBrand(brandName);
            Search.Click();
        }
    }
}