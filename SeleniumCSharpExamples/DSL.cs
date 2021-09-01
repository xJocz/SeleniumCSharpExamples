﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpExamples.Factory;

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
            if (type == "name")
            {
                DriverFactory.getDriver().FindElement(By.Name(selector)).Click();
            }
        }

        public string getText(string selector)
        {
            string Attr = DriverFactory.getDriver().FindElement(By.Id(selector)).Text;
            return Attr;
        }

        public string getTextByClassName(string selector)
        {
            string result = DriverFactory.getDriver().FindElement(By.ClassName(selector)).Text;
            return result;
        }

        public IWebElement getElement(string selector)
        {
            IWebElement element = DriverFactory.getDriver().FindElement(By.Id(selector));
            return element;
        }

        public void setText(string selector, string value)
        {
            DriverFactory.getDriver().FindElement(By.Id(selector)).Clear();
            DriverFactory.getDriver().FindElement(By.Id(selector)).SendKeys(value);
        }

        public void selectOptionByValue(string selector, string value)
        {
            IWebElement selectElement = DriverFactory.getDriver().FindElement(By.Id(selector));
            var selectObject = new SelectElement(selectElement);
            selectObject.SelectByValue(value);
        }

        public void selectOptionByText(string selector, string value)
        {
            IWebElement selectElement = DriverFactory.getDriver().FindElement(By.Id(selector));
            var selectObject = new SelectElement(selectElement);
            selectObject.SelectByText(value);
        }
    }
}
