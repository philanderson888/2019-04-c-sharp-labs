using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using NUnit;


namespace Selenium_02
{
    class NUnitTests
    {
        IWebDriver driver;

        [SetUp]
        public void Initialise()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void OpenAppTest()
        {
           // driver.Url = "https://www.bbc.co.uk";
        }

        [TearDown]
        public void EndTest()
        {
            System.Threading.Thread.Sleep(2000);
            driver.Close();
        }
    }
}
