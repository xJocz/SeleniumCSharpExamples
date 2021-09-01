using OpenQA.Selenium;

namespace SeleniumCSharpExamples
{
    class ContactPage
    {
        private DSL dsl;

        public ContactPage()
        {
            dsl = new DSL();
        }

        public void selectSubject(string value)
        {
            dsl.selectOptionByText("id_contact", value);
        }

        public void SetEmail(string email)
        {
            dsl.SetText("email", email);
        }

        public void SetOrderNumber(string order)
        {
            dsl.SetText("id_order", order);
        }

        public void SetMessage(string message)
        {
            dsl.SetText("message", message);
        }

        public void SendMessage()
        {
            dsl.Click("id", "submitMessage");
        }

        public string GetSuccessMessage()
        {
            return dsl.GetTextByClassName("alert-success");
        }

        public string GetErrorMessage()
        {
            return dsl.GetTextByClassName("alert-danger");
        }
    }
}