using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumCSharpExamples
{
    class DSL
    {
        private IWebDriver driver;

        public DSL(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void click(string type, string selector)
        {
            if (type == "xpath")
            {
                driver.FindElement(By.XPath(selector)).Click();
            }
            if (type == "id")
            {
                driver.FindElement(By.Id(selector)).Click();
            }
        }

        public String getText(string selector)
        {
            String Attr = driver.FindElement(By.Id(selector)).Text;
            return Attr;
        }

        public IWebElement getElement(String selector)
        {
            IWebElement element = driver.FindElement(By.Id(selector));
            return element;
        }

        public void setText(String selector, String value)
        {
            driver.FindElement(By.Id(selector)).SendKeys(value);
        }

        public void selectOptionByValue(String selector, String value)
        {
            IWebElement selectElement = driver.FindElement(By.Id(selector));
            var selectObject = new SelectElement(selectElement);
            selectObject.SelectByValue(value);
        }

        public void selectOptionByText(String selector, String value)
        {
            IWebElement selectElement = driver.FindElement(By.Id(selector));
            var selectObject = new SelectElement(selectElement);
            selectObject.SelectByText(value);
        }
    }
}
