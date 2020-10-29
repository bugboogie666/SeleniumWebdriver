using Microsoft.Dynamics365.UIAutomation.Browser;
using SeleniumWebdriver.Interfaces;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Configuration
{
    class EnvironmentVariablesReader : IConfig
    {
        public BrowserType GetBrowser()
        {
            throw new NotImplementedException();
        }

        public SecureString GetCrmPassword()
        {
            var crmPassword = Environment.GetEnvironmentVariable(AppConfigKeys.CrmPassword, EnvironmentVariableTarget.User);
            
            return crmPassword.ToSecureString();
        }

        public Uri GetCrmUrl()
        {
            throw new NotImplementedException();
        }

        public SecureString GetCrmUsername()
        {
            var crmUsername = Environment.GetEnvironmentVariable(AppConfigKeys.CrmUsername, EnvironmentVariableTarget.User);
           
            return crmUsername.ToSecureString();
        }

        public string GetPassword()
        {
            throw new NotImplementedException();
        }

        public string GetUsername()
        {
            throw new NotImplementedException();
        }

        public string GetWebsite()
        {
            throw new NotImplementedException();
        }
    }
}
