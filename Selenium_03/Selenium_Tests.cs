using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;

namespace Selenium_03
{
   
    class Selenium_Tests
    {
        IWebDriver driver;
        IWebElement element;

        [SetUp]
        public void Initialise()
        {
            driver = new ChromeDriver();
            
        }



        [Test]
        public void Selenium_Test_BBC_Website()
        {

            driver.Url = "https://www.bbc.co.uk";
            //  Console.WriteLine($"Page Source is {driver.PageSource}");
            Console.WriteLine($"Page Source is {driver.PageSource.Length}");

            Console.WriteLine($"Driver is {driver.Url}");
            Console.WriteLine($"Page Title is {driver.Title}");
            driver.Navigate().GoToUrl("https://www.intel.com");
            Thread.Sleep(1500);
            driver.Navigate().Back();
            Thread.Sleep(1500);
            driver.Navigate().Forward();
            Thread.Sleep(1500);
            driver.Navigate().Back();
            Thread.Sleep(1500);
            driver.Navigate().Refresh();
            Thread.Sleep(1500);

            driver.Url = "http://34.244.111.198/";
            // IWebElement element = driver.FindElement(By.Id(""));
            element = driver.FindElement(By.Name("email"));
            element.Clear();
            element.SendKeys("admin@spartaglobal.com");
            Thread.Sleep(1500);


            element = driver.FindElement(By.Name("password"));
            element.Clear();
            element.SendKeys("Password1");
            Thread.Sleep(1500);

            element = driver.FindElement(By.ClassName("btn-primary"));
            element.Click();
            Thread.Sleep(1500);
        }

        [TearDown]
        public void EndTest()
        {
            System.Threading.Thread.Sleep(3000);
            driver.Close();
            driver.Quit(); // closes all windows regardless
        }
    }
}


