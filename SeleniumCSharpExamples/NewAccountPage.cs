namespace SeleniumCSharpExamples
{
    class NewAccountPage
    {
        private DSL dsl;

        public NewAccountPage()
        {
            this.dsl = new DSL();
        }

        public void SetGenderMale()
        {
            dsl.Click("id", "id_gender1");
        }

        public string GetUrl()
        {
            return dsl.GetUrl();
        }

        public void SetCustomerFirstName(string name)
        {
            dsl.SetText("customer_firstname", name);
        }

        public void SetCustomerLastName(string name)
        {
            dsl.SetText("customer_lastname", name);
        }

        public void SetPassword(string password)
        {
            dsl.SetText("passwd", password);
        }

        public void selectDay(string day)
        {
            dsl.selectOptionByValue("days", day);
        }

        public void selectMonth(string month)
        {
            dsl.selectOptionByValue("months", month);
        }
        
        public void selectYear(string year)
        {
            dsl.selectOptionByValue("years", year);
        }

        public void SetAddressFirstName(string adressFirstName)
        {
            dsl.SetText("firstname", adressFirstName);
        }

        public void SetAddressLastName(string addressLastName)
        {
            dsl.SetText("lastname", addressLastName);
        }

        public void SetCompanyName(string companyName)
        {
            dsl.SetText("company", companyName);
        }

        public void SetAddress(string address)
        {
            dsl.SetText("address1", address);
        }

        public void SetCity(string city)
        {
            dsl.SetText("city", city);
        }

        public void selectState(string state)
        {
            dsl.selectOptionByText("id_state", state);
        }

        public void SetPostalCode(string postalCode)
        {
            dsl.SetText("postcode", postalCode);
        }

        public void SetAdditionalInfo(string text)
        {
            dsl.SetText("other", text);
        }

        public void SetPhone(string phone)
        {
            dsl.SetText("phone", phone);
        }

        public void SetMobilePhone(string mobilePhone)
        {
            dsl.SetText("phone_mobile", mobilePhone);
        }

        public void SubmitNewAccount()
        {
            dsl.Click("id", "submitAccount");
        }

    }
}