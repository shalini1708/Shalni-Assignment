using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;

namespace unittestprojectselenium
{
    [TestClass]
    public class GoogleSearch
    {
        [TestMethod]
        public void FFSearch()
        {
            using (var driver = new FirefoxDriver())
            {

                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://www.google.com");

            }
        }
    }
}




