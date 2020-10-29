using Microsoft.Dynamics365.UIAutomation.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.Page;
using OpenQA.Selenium.Firefox;
using SeleniumWebdriver.Configuration;
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
        /**[AssemblyInitialize]
        public static void InitDriver(TestContext tc)
        {
            ObjectRepository.FromAppConfig = new AppConfigReader();
            ObjectRepository.FromEnviron = new EnvironmentVariablesReader();

            ObjectRepository.XrmBrowser = new Browser(ObjectRepository.FromAppConfig.GetBrowser());
        }**/
            
            
        
        [AssemblyInitialize]
        public static void InitDriverWithAdvancedSettings(TestContext tc)
        {
            ObjectRepository.FromAppConfig = new AppConfigReader();
            ObjectRepository.FromEnviron = new EnvironmentVariablesReader();
            

            ObjectRepository.XrmBrowser = new Browser(ObjectRepository.BrowserAdvancedSettings);

        }


       

    }
}
