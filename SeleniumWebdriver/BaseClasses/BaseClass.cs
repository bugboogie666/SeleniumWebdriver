using Microsoft.Dynamics365.UIAutomation.Api;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.BaseClasses
{
    public class BaseClass
    {
        private static IWebDriver GetFirefoxDriver()
        {
            return new FirefoxDriver();
        }

        private static IWebDriver GetChromeDriver()
        {
            return new ChromeDriver();
        }

        private static Browser GetXrmBrowser()
        {
            throw new NotImplementedException();
        }

       

    }
}
