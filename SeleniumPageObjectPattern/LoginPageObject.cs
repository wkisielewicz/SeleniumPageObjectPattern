using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumPageObjectPattern
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "uname")]
        public IWebElement NameField { get; set; }

        [FindsBy(How = How.Id, Using = "upasswd")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.Id, Using = "signinBtn")]
        public IWebElement SignInButton { get; set; }
    }
}
