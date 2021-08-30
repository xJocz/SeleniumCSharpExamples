﻿using OpenQA.Selenium;

namespace SeleniumCSharpExamples
{
    class HomePage
    {
        private DSL dsl;

        public HomePage()
        {
            dsl = new DSL();
        }

        public string getUrl()
        {
            return dsl.getUrl();
        }

        public void navigate(string url)
        {
            dsl.navigate(url);
        }

        public void clickSignIn()
        {
            dsl.click("xpath", "//a[@class='login']");
        }

        public void setNewEmailAccount(string email)
        {
            dsl.setText("email_create", email);
        }

        public void openNewAccountForm()
        {
            dsl.click("id", "SubmitCreate");
        }

        public void openContactUs()
        {
            dsl.click("id", "contact-link");
        }

        public IWebElement getElement()
        {
            return dsl.getElement("create_account_error");
        }
    }
}
