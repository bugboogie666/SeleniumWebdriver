using SeleniumWebdriver.Interfaces;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
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

        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
        }

        public string GetUsername()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Username);
        }


    }
}
