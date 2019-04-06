using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Helper
{
    class ScreenshotHelper
    {
        public static void TakeScreenshot(IWebDriver driver)
        {
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            string screenshot = ss.AsBase64EncodedString;
            byte[] screenshotAsByteArray = ss.AsByteArray;
            string title = DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss");
            string screenshotfilename = "C:\\screenshots\\" + title + ".jpg";
            ss.SaveAsFile(screenshotfilename, OpenQA.Selenium.ScreenshotImageFormat.Jpeg);
            ss.ToString();
        }

        public static void TakeScreenshot(IWebDriver driver, IWebElement element)
        {
            DriverHelper.MoveToElement(driver, element);
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            string screenshot = ss.AsBase64EncodedString;
            byte[] screenshotAsByteArray = ss.AsByteArray;
            string title = DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss");
            string screenshotfilename = "C:\\screenshots\\" + title + ".jpg";
            ss.SaveAsFile(screenshotfilename, OpenQA.Selenium.ScreenshotImageFormat.Jpeg);
            ss.ToString();
        }
    }
}
