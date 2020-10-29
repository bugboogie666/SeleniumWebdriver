using System;
using Microsoft.Dynamics365.UIAutomation.Api;
using Microsoft.Dynamics365.UIAutomation.Browser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.PageNavigation
{
    [TestClass]
    public class TestPageNavigation
    {
    
        [TestMethod]
        public void OpenAPage()
        {
            var page = ObjectRepository.XrmBrowser.Driver.Navigate();
            page.GoToUrl(ObjectRepository.FromAppConfig.GetWebsite());
            ObjectRepository.XrmBrowser.Driver.Close();
        }

        [TestMethod]
        public void OpenDynamicsPage()
        {
            var url = ObjectRepository.FromAppConfig.GetCrmUrl();
            var password = ObjectRepository.FromEnviron.GetCrmPassword();
            var username = ObjectRepository.FromEnviron.GetCrmUsername();
            var browser = ObjectRepository.XrmBrowser;

            /**
            browser.LoginPage.Login(url, username, password); 
                        
            browser.ThinkTime(500);

            browser.GuidedHelp.CloseGuidedHelp();

            browser.Navigation.SignOut();

            //var areas = browser.Navigation.GetAreas();     
            **/
            var app = ObjectRepository.XrmApp;
            app.OnlineLogin.Login(url, username, password);
            app.Navigation.OpenApp("Kentico CRM App");
            app.Navigation.OpenSubArea("Sales", "Leads");
            app.ThinkTime(1000);
            app.Navigation.OpenAbout();
            //app.Navigation.SignOut();
            

        }
        public static void ADFSLoginAction(LoginRedirectEventArgs args)
        {



        }
    }

}
