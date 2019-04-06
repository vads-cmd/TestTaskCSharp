using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using TestTask.Helper;

namespace TestTask.Model
{
    class ResultsPage
    {
        private IWebDriver driver;

        public ResultsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@class = 'r']/..//h3[@class = 'LC20lb']")]
        private IList<IWebElement> results;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'kp-blk')]")]
        private IWebElement featuredSnippet;

        public IList<IWebElement> GetResultList()
        {
            return results;
        }

        public bool IsSnippetPresent()
        {
            return DriverHelper.IsElementPresent(featuredSnippet);
        }
    }
}
