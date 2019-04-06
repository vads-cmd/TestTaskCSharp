using System;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestTask.Model;
using TestTask.Helper;



namespace TestTask
{
    class GoogleTest
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void TestGoogle ()
        {

            //Preconditions
            int resultNumber = 4;
            String searchRequest = "Selenium IDE export to C#";
            String expected = StringHelper.ConvertString("Selenium IDE");

            //Actions
            HomePage homePage = new HomePage(driver);
            homePage.OpenHome();
            ResultsPage results = homePage.Search(searchRequest);
            if (!results.IsSnippetPresent())
            {
                resultNumber--;
            }
            IWebElement testedElement = results.GetResultList().ElementAt(resultNumber);

            //Assertions
            StringAssert.Contains(expected, StringHelper.ConvertString(testedElement.Text));
            ScreenshotHelper.TakeScreenshot(driver, testedElement);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }

    }
}
