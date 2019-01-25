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

        static void Main(string[] args)
        {
            
        }
                
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.ncbi.nlm.nih.gov/pubmed/");
        }

        [Test]
        public void ExecuteTets()
        {
            SetMethods.SelectDropDown("database", "PMC", PropertyType.Id);
            SetMethods.EnterText("term", "genes", PropertyType.Id);
            SetMethods.Click("search", PropertyType.Id);
        }

        [TearDown]
        public void Clean()
        {
            PropertiesCollection.driver.Close();
        }
    }
}
