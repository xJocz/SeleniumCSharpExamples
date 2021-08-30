using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpExamples.Factory;
using System;

namespace SeleniumCSharpExamples
{
    class DSL
    {
        public void navigate(string url)
        {
            DriverFactory.getDriver().Navigate().GoToUrl(url);
        }

        public string getUrl()
        {
            return DriverFactory.getDriver().Url;
        }

        public void click(string type, string selector)
        {
            if (type == "xpath")
            {
                DriverFactory.getDriver().FindElement(By.XPath(selector)).Click();
            }
            if (type == "id")
            {
                DriverFactory.getDriver().FindElement(By.Id(selector)).Click();
            }
        }

        public String getText(string selector)
        {
            String Attr = DriverFactory.getDriver().FindElement(By.Id(selector)).Text;
            return Attr;
        }

        public string getTextByClassName(string selector)
        {
            string result = DriverFactory.getDriver().FindElement(By.ClassName(selector)).Text;
            return result;
        }

        public IWebElement getElement(String selector)
        {
            IWebElement element = DriverFactory.getDriver().FindElement(By.Id(selector));
            return element;
        }

        public void setText(String selector, String value)
        {
            DriverFactory.getDriver().FindElement(By.Id(selector)).Clear();
            DriverFactory.getDriver().FindElement(By.Id(selector)).SendKeys(value);
        }

        public void selectOptionByValue(String selector, String value)
        {
            IWebElement selectElement = DriverFactory.getDriver().FindElement(By.Id(selector));
            var selectObject = new SelectElement(selectElement);
            selectObject.SelectByValue(value);
        }

        public void selectOptionByText(String selector, String value)
        {
            IWebElement selectElement = DriverFactory.getDriver().FindElement(By.Id(selector));
            var selectObject = new SelectElement(selectElement);
            selectObject.SelectByText(value);
        }
    }
}
