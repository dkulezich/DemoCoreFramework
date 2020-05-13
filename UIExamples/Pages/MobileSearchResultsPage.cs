using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using UIFramework.BasePage;

namespace UIExamples.Pages
{
    public class MobileSearchResultsPage : BasePage
    {
        public MobileSearchResultsPage(IWebDriver driver) : base(driver)
        {
            driver.Navigate().GoToUrl("https://www.mobile.bg/pcgi/mobile.cgi?act=3&slink=fdvquc&f1=1");
        }

        public IEnumerable<IWebElement> Results => Driver.FindElements(By.CssSelector("table [style^='width:660px; margin-bottom:0px;']"));

        public bool ResultIsPresent(string brandName)
        {
            return Results.Any();
        }
    }
}