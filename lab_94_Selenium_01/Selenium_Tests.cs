using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using NUnit.Framework;
using NUnit;

namespace lab_94_Selenium_01
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Url = "https://www.bbc.co.uk";
        //    Thread.Sleep(2000);
        //    driver.Close();  // one window
        //    driver.Quit();   // all 
        //}
    }

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
        public void Selenium_Test_BBC_Site()
        {
            driver.Url = "https://www.bbc.co.uk";
            // Console.WriteLine(driver.PageSource);

            Console.WriteLine($"Page Length {driver.PageSource.Length}");
            Console.WriteLine($"URL is {driver.Url}");
            Console.WriteLine($"Page Title is {driver.Title}");

            Thread.Sleep(1500);
            driver.Navigate().GoToUrl("https://www.intel.com");
            Thread.Sleep(1500);
            driver.Navigate().Back();
            Thread.Sleep(1500);
            driver.Navigate().Forward();
            Thread.Sleep(1500);
            driver.Navigate().Refresh();
            Thread.Sleep(1500);
            Thread.Sleep(1500);

        }

        [Test]
        public void Selenium_Test_Student_Portal()
        {
            driver.Url = "http://34.244.111.198";

            // select an individual web element on the page
            // find the email box
            element = driver.FindElement(By.Name("email"));
            // add text
            element.SendKeys("admin@spartaglobal.com");
            Thread.Sleep(1500);

            // find the password box
            element = driver.FindElement(By.Name("password"));
            element.SendKeys("Password1");
            Thread.Sleep(1500);

            // find submit button
            element = driver.FindElement(By.ClassName("btn-primary"));
            element.Click();
            Thread.Sleep(1500);


            element = driver.FindElement(By.LinkText("Users"));
            element.Click();
            Thread.Sleep(2000);

        }

        [TearDown]
        public void CleanUp()
        {
           Thread.Sleep(3000);
            driver.Close();   // one
            driver.Quit();  // all 
        }

    }
}
