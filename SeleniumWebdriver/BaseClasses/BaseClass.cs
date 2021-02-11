using Microsoft.Dynamics365.UIAutomation.Api;
using Microsoft.Dynamics365.UIAutomation.Api.UCI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Firefox;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Configuration;
using SeleniumWebdriver.CustomException;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.BaseClasses
{
    [TestClass]
    public class BaseClass
    {        
        [AssemblyInitialize]
        public static void InitDriverWithAdvancedSettings(TestContext tc)
        {
            ObjectRepository.FromAppConfig = new AppConfigReader();
            ObjectRepository.FromEnviron = new EnvironmentVariablesReader();

            try
            {
                var client = new WebClient(ObjectRepository.BrowserAdvancedSettings);
                ObjectRepository.XrmApp = new XrmApp(client);
                ObjectRepository.WebDriver = client?.Browser.Driver;
            }
            catch (Exception)
            {
                throw new NoSuitableDriverFound($"No such browser: {ObjectRepository.BrowserAdvancedSettings.BrowserType}");
            }

        }

        [AssemblyCleanup]
        public static void CloseDriver()
        {
            NavigationHelper.SignOut();
           
        }


       

    }
}
