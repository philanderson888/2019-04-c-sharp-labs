using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Selenium_01
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
          //  driver.Url = "https://www.bbc.co.uk";
        }

        [TearDown]
        public void EndTest()
        {
            System.Threading.Thread.Sleep(2000);
            driver.Close();
        }
    }
    
}
