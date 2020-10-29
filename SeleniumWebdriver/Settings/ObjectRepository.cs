using Microsoft.Dynamics365.UIAutomation.Api;
using Microsoft.Dynamics365.UIAutomation.Browser;
using OpenQA.Selenium;
using SeleniumWebdriver.Configuration;
using SeleniumWebdriver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Settings
{
    public static class ObjectRepository
    {
        public static IConfig FromAppConfig { get; set; }

        public static IConfig FromEnviron { get; set; }

        public static Browser XrmBrowser { get; set; }

        public static BrowserOptions BrowserAdvancedSettings => TestSettings.Options;
    }
}
