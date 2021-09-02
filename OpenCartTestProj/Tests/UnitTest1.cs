
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace OpenCartTestProj.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        private IWebDriver browser;

        [SetUp]
        public void SetUp()
        {
            browser = new ChromeDriver();
            const string URL = "http://localhost/index.php?route=common/home";
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            browser.Navigate().GoToUrl(URL);
            browser.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            bool isDisplyed = browser.FindElement(By.Id("logo")).Displayed;

            Assert.IsTrue(isDisplyed);
        }

        [TearDown]
        public void TearDoun()
        {
            browser.Quit();
        }
    }
}
