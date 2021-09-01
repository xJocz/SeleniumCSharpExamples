using OpenQA.Selenium;

namespace SeleniumCSharpExamples
{
    class HomePage
    {
        private DSL dsl;

        public HomePage()
        {
            dsl = new DSL();
        }

        public string GetUrl()
        {
            return dsl.GetUrl();
        }

        public void Navigate(string url)
        {
            dsl.Navigate(url);
        }

        public void ClickSignIn()
        {
            dsl.Click("xpath", "//a[@class='login']");
        }

        public void SetNewEmailAccount(string email)
        {
            dsl.SetText("email_create", email);
        }

        public void OpenNewAccountForm()
        {
            dsl.Click("id", "SubmitCreate");
        }

        public void OpenContactUs()
        {
            dsl.Click("id", "contact-link");
        }

        public IWebElement GetElement()
        {
            return dsl.GetElement("create_account_error");
        }

        public void SetNewsletterInput(string email)
        {
            dsl.SetText("newsletter-input", email);
        }

        public void SubmitNewsletter()
        {
            dsl.Click("name", "submitNewsletter");
        }

        public string GetNewsletterResult(string type)
        {
            if (type == "success")
            {
                return dsl.GetTextByClassName("alert-success");
            } 
            else
            {
                return dsl.GetTextByClassName("alert-danger");
            }
        }
    }
}
