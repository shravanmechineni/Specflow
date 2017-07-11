using System;
using System.Threading;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using SpecflowDemo.Utils;
using System.Data;
using TechTalk.SpecFlow.Assist;
using System.Collections.Generic;

namespace SpecflowDemo.Steps
{
    [Binding]
    public class Facebook_LoginSteps
    {
        //public Facebook_LoginSteps(IWebDriver driver) : base(driver)
        //{

        //}

        public static IWebDriver driver;

        public Facebook_LoginSteps()
        {

              driver = new ChromeDriver(@"C:\SeleniumDrivers");
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        [AfterScenario(Order = 2)]
        public void AfterScenario()
        {
            driver.Quit();
        }

        [AfterScenario(Order = 1)]
        [Scope(Tag = "shravan")]
        public void AfterScenarioShravan()
        {
            Console.WriteLine("Shravan logging out");
        }

        [AfterScenario("ravali")]
        public void AfterScenarioRavali()
        {
            Console.WriteLine("Ravali logging out");
        }

        [Given(@"I am on ""(.*)""")]
        public void GivenIAmOn(string url)
        {
            driver.Navigate().GoToUrl(url);
           // Thread.Sleep(3000);
        }
        
        [Given(@"I fill ""(.*)"" as ""(.*)""")]
        public void GivenIFillAs(string locator, string value)
        {
            driver.FindElement(By.CssSelector(locator)).SendKeys(value);
            // ScenarioContext.Current[locator] = value;
            // OR
            ScenarioContext.Current.Add(locator, value);
        }
        
        [When(@"I click on ""(.*)"" button")]
        public void WhenIClickOnButton(string locator)
        {
            driver.FindElement(By.CssSelector(locator)).Click();
        }
        
        [Then(@"I should logged in successfully")]
        public void ThenIShouldLoggedInSuccessfully()
        {
            var count = driver.FindElement(By.CssSelector("#userNavigationLabel")).Size;
          //  Assert.NotNull(count, "Not logged in: Please verify");

            //This Checks that if the LogOut button is displayed
            true.Equals(driver.FindElement(By.CssSelector("#userNavigationLabel")).Displayed);
           // var username = (string)ScenarioContext.Current["#email"];
            // OR
            //var username = ScenarioContext.Current.Get<string>("#email");
            //Console.WriteLine("Username: "+username);
            //var password = (string)ScenarioContext.Current["#pass"];
            //Console.WriteLine("Password: "+password);
        }

        // Transfer table into dictionary
        [Scope(Tag = "dictionary")]
        [Given(@"I enter below credentials")]
        public void GivenIEnterBelowCredentials(Table table)
        {
            var dictionary = TableExtensions.ToDictionary(table);
            var test = dictionary["Username"];

            driver.FindElement(By.CssSelector("#email")).SendKeys(dictionary["Username"]);
            driver.FindElement(By.CssSelector("#pass")).SendKeys(dictionary["Password"]);

        }

        //Tranfer table into datatable
        [Scope(Tag = "datatable")]
        [Given(@"I enter below credentials")]
        public void IEnterBelowCredentials(Table table)
        {
            var dataTable = TableExtensions.ToDataTable(table);
            foreach (DataRow row in dataTable.Rows)
            {
                driver.FindElement(By.CssSelector("#email")).SendKeys(row.ItemArray[0].ToString());
                driver.FindElement(By.CssSelector("#pass")).SendKeys(row.ItemArray[1].ToString());
            }
        }

        //CreateInstance in SpecFlow Table
        [Scope(Tag = "createinstance")]
        [Given(@"I enter below credentials")]
        public void IEnterCredentials(Table table)
        {
            var credentials = table.CreateInstance<Credentials>();
            driver.FindElement(By.CssSelector("#email")).SendKeys(credentials.Username);
            driver.FindElement(By.CssSelector("#pass")).SendKeys(credentials.Password);
        }

        //CreateSet in SpecFlow Table
        [Scope(Tag = "createset")]
        [Given(@"I enter below credentials")]
        public void IEnterCredential(Table table)
        {
            var credentials = table.CreateSet<Credentials>();
            foreach (var userdata in credentials) {
                driver.FindElement(By.CssSelector("#email")).SendKeys(userdata.Username);
                driver.FindElement(By.CssSelector("#pass")).SendKeys(userdata.Password);
            }
        }

        //CreatedynamicSet in SpecFlow Assist Dynamic
        [Scope(Tag = "createdynamicset")]
        [Given(@"I enter below credentials")]
        public void IEnterCredentialss(Table table)
        {
            IEnumerable<dynamic> credentials = table.CreateDynamicSet();
            foreach (var userdata in credentials)
            {
                driver.FindElement(By.CssSelector("#email")).SendKeys(userdata.Username);
                driver.FindElement(By.CssSelector("#pass")).SendKeys(userdata.Password);
            }
        }

        //CreatedynamicInstance in SpecFlow Assist Dynamic
        [Scope(Tag = "createdynamicinstance")]
        [Given(@"I enter below credentials")]
        public void IEnterCredentialsss(Table table)
        {
            dynamic credentials = table.CreateDynamicInstance();
                driver.FindElement(By.CssSelector("#email")).SendKeys(credentials.Username);
                driver.FindElement(By.CssSelector("#pass")).SendKeys(credentials.Password);
        }
    }
}

