﻿using System;
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
        public static string GetText(string element, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute(value);
            if (elementtype == PropertyType.Name)
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute(value);
            else return String.Empty;
        }

        public static string GetTextDDL(string element, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementtype == PropertyType.Name)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return String.Empty;
        }
    }
}
