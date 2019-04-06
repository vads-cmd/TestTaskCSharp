using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Model
{
    class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement searchField;

        [FindsBy(How = How.Name, Using = "btnK")]
        private IWebElement submitButton;

        public void OpenHome()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
        }

        public ResultsPage Search(String searchText)
        {
            searchField.Clear();
            searchField.SendKeys(searchText);
            submitButton.Click();
            return new ResultsPage(driver);
        }
    }
}
