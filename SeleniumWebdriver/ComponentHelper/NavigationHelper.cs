using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigateToUrl(string url)
        {
            ObjectRepository.WebDriver.Navigate().GoToUrl(url);
        }

        public static void LoginAndOpenDynamicsApp(string appName, Uri url, SecureString username, SecureString password)
        {            
            ObjectRepository.XrmApp.OnlineLogin.Login(url, username, password);
            ObjectRepository.XrmApp.Navigation.OpenApp(appName);
        }

        public static void NavigateToSubarea(string area, string subarea)
        {
            ObjectRepository.XrmApp.Navigation.OpenSubArea(area, subarea);
            ObjectRepository.XrmApp.ThinkTime(1000);
        }

        public static void SignOut()
        {
            ObjectRepository.XrmApp.Navigation.SignOut();
            ObjectRepository.XrmApp.ThinkTime(5000);
            ObjectRepository.WebDriver.Close();
        }

        
    }
}
