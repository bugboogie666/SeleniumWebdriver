using Microsoft.Dynamics365.UIAutomation.Api;
using OpenQA.Selenium;
using SeleniumWebdriver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Settings
{
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }

        public static Browser XrmBrowser { get; set; }
    }
}
