using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
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

        public static void LoginToDynamics(string appName, Uri url, string username, string password)
        {
            ObjectRepository.WebDriver.Navigate().GoToUrl(url);            
            WebDriverWait wait = new WebDriverWait(ObjectRepository.WebDriver,TimeSpan.FromSeconds(10));

            var usernameContainer = wait.Until(ExpectedConditions.ElementExists(By.Id("i0116")));            
            usernameContainer.SendKeys(username);            
            var next = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("idSIButton9")));
            next.Click();

            var passwordContainer = wait.Until(ExpectedConditions.ElementExists(By.Id("i0118")));
            passwordContainer.SendKeys(password);
            var signIn = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("idSIButton9")));
            signIn.Click();

            var yes = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("idSIButton9")));
            yes.Click();

            ObjectRepository.XrmApp.Navigation.OpenApp(appName);




        }

        
    }
}
