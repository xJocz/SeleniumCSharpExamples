using NUnit.Framework;
using SeleniumCSharpExamples.Factory;
using System;

namespace SeleniumCSharpExamples
{
    public class Tests
    {
        private HomePage homePage;
        private NewAccountPage newAccountPage;
        private ContactPage contactPage;
        private string siteUrl = "http://automationpractice.com/index.php";
        int randomNumber = new Random().Next(10000, 99999);

        [SetUp]
        public void Setup()
        {
            DriverFactory.getDriver();
            homePage = new HomePage();
            newAccountPage = new NewAccountPage();
            contactPage = new ContactPage();
        }

        [Test]
        public void GoToSite()
        {
            homePage.Navigate(siteUrl);
            Assert.AreEqual(siteUrl, homePage.GetUrl());
        }

        [Test]
        public void CreateNewAccountToFail()
        {
            homePage.Navigate(siteUrl);
            homePage.ClickSignIn();
            homePage.OpenNewAccountForm();
            Assert.IsNotNull(homePage.GetElement());
        }

        [Test]
        public void CreateNewAccountToSuccess()
        {
            string urlNewAccountCreated = "http://automationpractice.com/index.php?controller=my-account";
            homePage.Navigate(siteUrl);
            homePage.ClickSignIn();
            homePage.SetNewEmailAccount("mail" + randomNumber + "@test.com");
            homePage.OpenNewAccountForm();
            newAccountPage.SetGenderMale();
            newAccountPage.SetCustomerFirstName("firstName");
            newAccountPage.SetCustomerLastName("lastName");
            newAccountPage.SetPassword("Qwer!234");
            newAccountPage.selectDay("4");
            newAccountPage.selectMonth("6");
            newAccountPage.selectYear("1990");
            newAccountPage.SetAddressFirstName("Address first name");
            newAccountPage.SetAddressLastName("Address last name");
            newAccountPage.SetCompanyName("Easy");
            newAccountPage.SetAddress("Kansas Avenue 1860");
            newAccountPage.SetCity("Alabama");
            newAccountPage.selectState("Kansas");
            newAccountPage.SetPostalCode("03355");
            newAccountPage.SetAdditionalInfo("no additional info for this example");
            newAccountPage.SetPhone("+551144101234");
            newAccountPage.SetMobilePhone("+5511974391234");
            newAccountPage.SubmitNewAccount();
            Assert.AreEqual(urlNewAccountCreated, newAccountPage.GetUrl());
        }

        [Test]
        public void SendMessageToFail()
        { 
            homePage.Navigate(siteUrl);
            homePage.OpenContactUs();
            contactPage.selectSubject("Webmaster");
            contactPage.SetEmail("mail" + randomNumber + "@test.com");
            contactPage.SetOrderNumber(randomNumber.ToString());
            contactPage.SendMessage();
            Assert.AreEqual("There is 1 error\r\nThe message cannot be blank.", contactPage.GetErrorMessage()); 
        }

        [Test]
        public void SendMessageToSuccess()
        {
            homePage.Navigate(siteUrl);
            homePage.OpenContactUs();
            contactPage.selectSubject("Webmaster");
            contactPage.SetEmail("mail" + randomNumber + "@test.com");
            contactPage.SetOrderNumber(randomNumber.ToString());
            contactPage.SetMessage("This is a simple message to dev teams about this test");
            contactPage.SendMessage();
            Assert.AreEqual("Your message has been successfully sent to our team.", contactPage.GetSuccessMessage());
        }

        [Test]
        public void SubscribeToNewsletterToFail()
        {
            string resultSubscribe = "Newsletter : Invalid email address.";
            homePage.Navigate(siteUrl);
            homePage.SetNewsletterInput("mail" + randomNumber);
            homePage.SubmitNewsletter();
            Assert.AreEqual(homePage.GetNewsletterResult("error"), resultSubscribe);

        }

        [Test]
        public void SubscribeToNewsletterRepeatedEmail()
        {
            string resultSubscribe = "Newsletter : This email address is already registered.";
            string repeatedEmail = "test@test.br";
            homePage.Navigate(siteUrl);
            homePage.SetNewsletterInput(repeatedEmail);
            homePage.SubmitNewsletter();
            Assert.AreEqual(homePage.GetNewsletterResult("error"), resultSubscribe);
        }

        [Test]
        public void SubscribeToNewsletterToSuccess()
        {
            string resultSubscribe = "Newsletter : You have successfully subscribed to this newsletter.";
            homePage.Navigate(siteUrl);
            homePage.SetNewsletterInput("mail" + randomNumber + "@test.br");
            homePage.SubmitNewsletter();
            Assert.AreEqual(homePage.GetNewsletterResult("success"), resultSubscribe);
        }


        [TearDown]
        public void TearDown()
        {
            DriverFactory.killDriver();
        }
    }
}