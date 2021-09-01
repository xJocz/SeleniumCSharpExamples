namespace SeleniumCSharpExamples
{
    class NewAccountPage
    {
        private DSL dsl;

        public NewAccountPage()
        {
            this.dsl = new DSL();
        }

        public void setGenderMale()
        {
            dsl.click("id", "id_gender1");
        }

        public string getUrl()
        {
            return dsl.getUrl();
        }

        public void setCustomerFirstName(string name)
        {
            dsl.setText("customer_firstname", name);
        }

        public void setCustomerLastName(string name)
        {
            dsl.setText("customer_lastname", name);
        }

        public void setPassword(string password)
        {
            dsl.setText("passwd", password);
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

        public void setAddressFirstName(string adressFirstName)
        {
            dsl.setText("firstname", adressFirstName);
        }

        public void setAddressLastName(string addressLastName)
        {
            dsl.setText("lastname", addressLastName);
        }

        public void setCompanyName(string companyName)
        {
            dsl.setText("company", companyName);
        }

        public void setAddress(string address)
        {
            dsl.setText("address1", address);
        }

        public void setCity(string city)
        {
            dsl.setText("city", city);
        }

        public void selectState(string state)
        {
            dsl.selectOptionByText("id_state", state);
        }

        public void setPostalCode(string postalCode)
        {
            dsl.setText("postcode", postalCode);
        }

        public void setAdditionalInfo(string text)
        {
            dsl.setText("other", text);
        }

        public void setPhone(string phone)
        {
            dsl.setText("phone", phone);
        }

        public void setMobilePhone(string mobilePhone)
        {
            dsl.setText("phone_mobile", mobilePhone);
        }

        public void submitNewAccount()
        {
            dsl.click("id", "submitAccount");
        }

    }
}