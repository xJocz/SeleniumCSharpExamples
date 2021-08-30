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

        public void setEmail(string email)
        {
            dsl.setText("email", email);
        }

        public void setOrderNumber(string order)
        {
            dsl.setText("id_order", order);
        }

        public void setMessage(string message)
        {
            dsl.setText("message", message);
        }

        public void sendMessage()
        {
            dsl.click("id", "submitMessage");
        }

        public string getSuccessMessage()
        {
            return dsl.getTextByClassName("alert-success");
        }

        public string getErrorMessage()
        {
            return dsl.getTextByClassName("alert-danger");
        }
    }
}