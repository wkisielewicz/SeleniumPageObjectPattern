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
            string title_value = page.SearchTitleName.Text;
            Assert.That(title_value, Does.Match("Search results"));
        }

        // Check that empty search redirect to the correct page with all NCBI databases
        [Test]
        public void EmptySearchOperation()
        {
            MainPageObject page = new MainPageObject();
            page.SearchButton.Click();
            string title_value = page.NcbiDatabasesSearchTitleName.Text;
            Assert.That(title_value, Does.Match("NCBI Databases"));
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

        // Check if about page conatins all needed sections
        [Test]
        public void AboutNcbiPageContent()
        {
            MainPageObject page = new MainPageObject();
            page.AboutNcbiPageLink.Click();
            string our_mission_value = page.OurMissionSection.Text;
            string structure_value = page.StructureSection.Text;
            string programs_value = page.ProgramSection.Text;
            string researchers_value = page.ResearchersSection.Text;
            Assert.That(our_mission_value, Does.Contain("Our"));
            Assert.That(structure_value, Does.Contain("Organizational"));
            Assert.That(programs_value, Does.Contain("Programs"));
            Assert.That(researchers_value, Does.Contain("Researchers"));

        }

        //Check if main page contains all needed sections
        [Test]
        public void MainPageContent()
        {
            MainPageObject page = new MainPageObject();
            page.SubmitColumn.Click();
            page.SubmitDropBox.SendKeys("GenBank");
            page.SubmitGenBankDropBox.SendKeys("Third Party Annotations (TPA");
            page.SubmitDataButton.Click();
            Assert.That(page.HowToSubmitSequenceData, Does.Match("How to Submit TPA Sequence Data"));
        }


        [TearDown]
        public void Clean()
        {
            PropertiesCollection.driver.Close();
        }
    }
}
