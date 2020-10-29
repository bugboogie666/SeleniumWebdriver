using Microsoft.Dynamics365.UIAutomation.Browser;
using SeleniumWebdriver.Interfaces;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Configuration
{
    public class AppConfigReader : IConfig
    {
        public BrowserType GetBrowser()
        {
            var browser =  ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);

            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
        }

        public SecureString GetCrmPassword()
        {
            var crmPassword = Environment.GetEnvironmentVariable(AppConfigKeys.CrmPassword,EnvironmentVariableTarget.User);
            //return ConfigurationManager.AppSettings.Get(AppConfigKeys.CrmPassword).ToSecureString();
            return crmPassword.ToSecureString();
        }

        public Uri GetCrmUrl()
        {
            return new Uri(ConfigurationManager.AppSettings.Get(AppConfigKeys.OnlineCrmUrl));
        }

        public SecureString GetCrmUsername()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.CrmUsername).ToSecureString();
        }

        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
        }

        public string GetUsername()
        {
            
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Username);
        }

        public string GetWebsite()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Website);
            
        }
    }
}
