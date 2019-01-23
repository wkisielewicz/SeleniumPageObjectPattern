using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumPageObjectPattern
{
    class GetMethods
    {
        public static string GetText(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                return driver.FindElement(By.Id(element)).GetAttribute(value);
            if (elementtype == "Name")
                return driver.FindElement(By.Id(element)).GetAttribute(value);
            else return String.Empty;
        }

        public static string GetTextDDL(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementtype == "Name")
                return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return String.Empty;
        }
    }
}
