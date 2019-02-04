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
    class BasicNavigationFlowNCBI
    {

        static void Main(string[] args)
        {
            
        }
                
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.ncbi.nlm.nih.gov/");
        }

        // Check that searching in PubMed databse is possible
        [Test]
        public void SearchInPubmed()
        {
            MainPageObject page = new MainPageObject();
            page.DropBox.SendKeys("Pubmed");
            page.SearchBox.SendKeys("genes");
            page.SearchButton.Click();
            string value = page.SearchTitleName.Text;
            Assert.That(value, Does.Match("Search results"));
        }

        // Check that empty search redirect to the correct page with all NCBI databases
        [Test]
        public void EmptySearchOperation()
        {
            MainPageObject page = new MainPageObject();
            page.SearchButton.Click();
            string value = page.NcbiDatabasesSearchTitleName.Text;
            Assert.That(value, Does.Match("NCBI Databases"));
        }

        // Check if all links in left sidebar are clickable
        [Test]
        public void LeftSidebarNavigation()
        {
            MainPageObject page = new MainPageObject();
            page.AllResourcesLink.Click();
            page.ChemicalBioassaysLink.Click();
            page.DataSoftwareLink.Click();
            page.DnaRnaLink.Click();
            page.DomainsStructuresLink.Click();
            page.GenesExpressionLink.Click();
            page.GeneticsMedicineLink.Click();
            page.GenomesMapsLink.Click();
            page.HomologyLink.Click();
            page.LiteratureLink.Click();
            page.ProteinsLink.Click();
            page.SequenceAnalysisLink.Click();
            page.TaxonomyLink.Click();
            page.TrainingTutorialsLink.Click();
            page.VariationLink.Click();         
        }



        [TearDown]
        public void Clean()
        {
            PropertiesCollection.driver.Close();
        }
    }
}
