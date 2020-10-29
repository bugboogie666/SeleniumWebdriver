using Microsoft.Dynamics365.UIAutomation.Browser;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Configuration
{
    public class TestSettings
    {
        public static BrowserOptions Options => new BrowserOptions
        {
            BrowserType = ObjectRepository.FromAppConfig.GetBrowser(),
            PrivateMode = true,
            FireEvents = false

        };
    }
}
