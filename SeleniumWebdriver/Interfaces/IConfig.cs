using Microsoft.Dynamics365.UIAutomation.Browser;
using SeleniumWebdriver.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Interfaces
{
    public interface IConfig
    {
        string GetUsername();
        string GetPassword();
        BrowserType GetBrowser();
        string GetWebsite();
        Uri GetCrmUrl();
        SecureString GetCrmUsername();
        SecureString GetCrmPassword();




    }
}
