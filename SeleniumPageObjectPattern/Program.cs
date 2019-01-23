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
    class Program
    {

        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
            
        }
                
        [SetUp]
        public void Initialize()
        {
            
            driver.Navigate().GoToUrl("https://www.ncbi.nlm.nih.gov/pubmed/");
        }

        [Test]
        public void ExecuteTets()
        {
            SetMethods.SelectDropDown(driver, "database", "PMC", "Id");
            SetMethods.EnterText(driver, "term", "genes", "Id");
            SetMethods.Click(driver,"search", "Id");
        }

        [TearDown]
        public void Clean()
        {
            driver.Close();
        }
    }
}
