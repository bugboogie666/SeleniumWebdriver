using System;
using System.Configuration;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SeleniumWebdriver.Configuration;
using SeleniumWebdriver.Interfaces;

namespace SeleniumWebdriver
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php"); // this will open the web page
            driver.Close(); //this will close the browser session
            driver.Quit(); // this will stop the webdriver

            IConfig configReader = new AppConfigReader();

            configReader.GetBrowser();
            
           
        }
    }
}
