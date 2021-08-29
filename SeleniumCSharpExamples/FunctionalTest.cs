using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumCSharpExamples
{
    public class Tests
    {
        private IWebDriver driver;
        private DSL dsl;
        private HomePage homePage;
        private NewAccountPage newAccountPage;
        private ContactPage contactPage;
        private string siteUrl = "http://automationpractice.com/index.php";

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            dsl = new DSL(driver);
            homePage = new HomePage(driver);
            newAccountPage = new NewAccountPage(driver);
            contactPage = new ContactPage(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void GoToSite()
        {
            homePage.navigate(siteUrl);
            Assert.AreEqual(siteUrl, driver.Url);
        }

        [Test]
        public void CreateNewAccountToFail()
        {
            homePage.navigate(siteUrl);
            homePage.clickSignIn();
            homePage.openNewAccountForm();
            Assert.IsNotNull(dsl.getElement("create_account_error"));
        }

        [Test]
        public void CreateNewAccountToSuccess()
        {
            int randomNumber = new Random().Next(1000, 9999);
            string urlNewAccountCreated = "http://automationpractice.com/index.php?controller=my-account";
            homePage.navigate(siteUrl);
            homePage.clickSignIn();
            homePage.setNewEmailAccount("mail" + randomNumber + "@test.com");
            homePage.openNewAccountForm();
            newAccountPage.setGenderMale();
            newAccountPage.setCustomerFirstName("firstName");
            newAccountPage.setCustomerLastName("lastName");
            newAccountPage.setPassword("Qwer!234");
            newAccountPage.selectDay("4");
            newAccountPage.selectMonth("6");
            newAccountPage.selectYear("1990");
            newAccountPage.setAddressFirstName("Address first name");
            newAccountPage.setAddressLastName("Address last name");
            newAccountPage.setCompanyName("Easy");
            newAccountPage.setAddress("Kansas Avenue 1860");
            newAccountPage.setCity("Alabama");
            newAccountPage.selectState("Kansas");
            newAccountPage.setPostalCode("03355");
            newAccountPage.setAdditionalInfo("no additional info for this example");
            newAccountPage.setPhone("+551144101234");
            newAccountPage.setMobilePhone("+5511974391234");
            newAccountPage.submitNewAccount();
            Assert.AreEqual(urlNewAccountCreated, newAccountPage.getUrl());
        }

        [Test]
        public void SendMessageToFail()
        {
            int randomNumber = new Random().Next(1000, 9999);
            homePage.navigate(siteUrl);
            homePage.openContactUs();
            contactPage.selectSubject("Webmaster");
            contactPage.setEmail("mail" + randomNumber + "@test.com");
            contactPage.setOrderNumber(randomNumber.ToString());
            contactPage.sendMessage();
            Assert.AreEqual("There is 1 error\r\nThe message cannot be blank.", contactPage.getErrorMessage()); 
        }

        [Test]
        public void SendMessageToSuccess()
        {
            int randomNumber = new Random().Next(1000, 9999);
            homePage.navigate(siteUrl);
            homePage.openContactUs();
            contactPage.selectSubject("Webmaster");
            contactPage.setEmail("mail" + randomNumber + "@test.com");
            contactPage.setOrderNumber(randomNumber.ToString());
            contactPage.setMessage("This is a simple message to dev teams about this test");
            contactPage.sendMessage();
            Assert.AreEqual("Your message has been successfully sent to our team.", contactPage.getSuccessMessage());
        }
       
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}