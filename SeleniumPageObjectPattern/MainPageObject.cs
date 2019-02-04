using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumPageObjectPattern
{
    class MainPageObject
    {

        public MainPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "database")]
        public IWebElement DropBox { get; set; }

        [FindsBy(How = How.Id, Using = "term")]
        public IWebElement SearchBox { get; set; }

        [FindsBy(How = How.Id, Using = "search")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.Id, Using = "Sign in to NCBI")] 
        public IWebElement LoginPageLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "All Resources")]
        public IWebElement AllResourcesLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Chemicals & Bioassays")]
        public IWebElement ChemicalBioassaysLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Data & Software")]
        public IWebElement DataSoftwareLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "DNA & RNA")]
        public IWebElement DnaRnaLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Domains & Structures")]
        public IWebElement DomainsStructuresLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Genes & Expression")]
        public IWebElement GenesExpressionLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Genetics & Medicine")]
        public IWebElement GeneticsMedicineLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Genomes & Maps")]
        public IWebElement GenomesMapsLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Homology")]
        public IWebElement HomologyLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Literature")]
        public IWebElement LiteratureLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Proteins")]
        public IWebElement ProteinsLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Sequence Analysis")]
        public IWebElement SequenceAnalysisLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Taxonomy")]
        public IWebElement TaxonomyLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Training & Tutorials")]
        public IWebElement TrainingTutorialsLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Variation")]
        public IWebElement VariationLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='maincontent']/div/div[3]/div[1]/h2")]
        public IWebElement SearchTitleName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main_content']/section[2]/div/h2")]
        public IWebElement NcbiDatabasesSearchTitleName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='maincontent']/div[1]/div/div/div/ul/li[1]/a")]
        public IWebElement AboutNcbiPageLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='maincontent_1']/section/h2")]
        public IWebElement OurMissionSection { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='maincontent_2']/section/h2")]
        public IWebElement StructureSection { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='maincontent_3']/section/h2")]
        public IWebElement ProgramSection { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='maincontent_4']/section/h2")]
        public IWebElement ResearchersSection { get; set; }
    }

   
}
