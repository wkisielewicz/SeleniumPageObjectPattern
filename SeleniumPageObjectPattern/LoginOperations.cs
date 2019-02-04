using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumPageObjectPattern
{
    class LoginOperations
    {
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.ncbi.nlm.nih.gov/account/?back_url=https%3A%2F%2Fwww.ncbi.nlm.nih.gov%2F");
        }

        //Login into NCBI account

        [Test]
        public void IncorrectLogin()
        {
            LoginPageObject page = new LoginPageObject();
            page.NameField.SendKeys("test");
            page.PasswordField.SendKeys("testpassword");
            page.SignInButton.Click();

        }

        [TearDown]
        public void Clean()
        {
            PropertiesCollection.driver.Close();
        }
    }
}
