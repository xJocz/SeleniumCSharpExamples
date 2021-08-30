using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpExamples.Factory
{
    class DriverFactory
    {
        private static IWebDriver driver;

        private DriverFactory()
        {

        }

        public static IWebDriver getDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
            }
            return driver;
        }

        public static void killDriver()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}
