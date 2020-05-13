using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace UIFramework.Extentions
{
    public static class WebDriverExtentions
    {
        public static bool WaitToExist(this IWebDriver self, By element, TimeSpan timeout)
        {
            return new WebDriverWait(self, timeout).Until(self => self.FindElement(element)).Displayed;
        }
    }
}