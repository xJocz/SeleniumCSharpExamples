using OpenQA.Selenium;

namespace SeleniumCSharpExamples
{
    class HomePage
    {
        private DSL dsl;

        public HomePage(IWebDriver driver)
        {
            dsl = new DSL(driver);
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
    }
}
