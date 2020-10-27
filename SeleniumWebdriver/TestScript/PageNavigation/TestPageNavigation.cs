using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.PageNavigation
{
    [TestClass]
    public class TestPageNavigation
    {
        [TestMethod]
        public void OpenAPage()
        {
            var page = ObjectRepository.XrmBrowser.Driver.Navigate();
            page.GoToUrl(ObjectRepository.Config.GetWebsite());
            ObjectRepository.XrmBrowser.Driver.Close();
        }
    }
}
