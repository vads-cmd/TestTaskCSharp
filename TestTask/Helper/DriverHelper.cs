using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Helper
{
    class DriverHelper
    {
        public static bool IsElementPresent(IWebElement element)
        {
            try
            {
                return element.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public static void HandleAlert(IWebDriver driver, bool accept)
        {
            IAlert alert = driver.SwitchTo().Alert();
            if (accept) { alert.Accept(); }
            else { alert.Dismiss(); }
        }

        public static void MoveToElement(IWebDriver driver, IWebElement element)
        {
            Actions a = new Actions(driver);
            a.MoveToElement(element).Perform();
        }
    }
}
