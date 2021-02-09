using System;
//using Microsoft.Dynamics365.UIAutomation.Api
using Microsoft.Dynamics365.UIAutomation.Api.UCI;
using Microsoft.Dynamics365.UIAutomation.Browser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.PageNavigation
{
    [TestClass]
    public class TestPageNavigation
    {
    
        [TestMethod]
        public void OpenAPage()
        {            
            NavigationHelper.NavigateTo(ObjectRepository.FromAppConfig.GetWebsite());
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
            
            //app.OnlineLogin.Login(url, username, password);
            //app.Navigation.OpenApp("Kentico CRM App");
            NavigationHelper.LoginAndOpenDynamicsApp("Kentico CRM App", url, username, password);
            //app.Navigation.OpenSubArea("Sales", "Leads");
            //app.ThinkTime(1000);
            NavigationHelper.NavigateToSubarea("Sales", "Leads");
            NavigationHelper.SignOut();
        }

        [TestMethod]
        public void ReinstatementShouldBeCreatedWhenOrderIsPaid3DaysAfterRenewalStarted()
        {
            var url = ObjectRepository.FromAppConfig.GetCrmUrl();
            var password = ObjectRepository.FromEnviron.GetCrmPassword();
            var username = ObjectRepository.FromEnviron.GetCrmUsername();
            
            //Login
            NavigationHelper.LoginAndOpenDynamicsApp("Kentico CRM App", url, username, password);
            //Navigate to orders
            NavigationHelper.NavigateToSubarea("Sales", "Orders");
            
            //create new order
            ObjectRepository.XrmApp.CommandBar.ClickCommand("New");
            ObjectRepository.XrmApp.Entity.SetValue("name", "hellofromselenium");
            ObjectRepository.XrmApp.Entity.SetValue("dyn_dealid", "898");
                       
            ObjectRepository.XrmApp.Entity.SetValue(new OptionSet { Name = "ken_movedfrom", Value = "Perpetual" });


            ObjectRepository.XrmApp.Entity.SetValue(new OptionSet { Name = "ken_billingofficetype", Value = "Kentico Software Ltd - UK Office" });

            ObjectRepository.XrmApp.Entity.SetValue(new OptionSet { Name = "ken_movedfrom", Value = "Perpetual" });

            ObjectRepository.XrmApp.Entity.SetValue(new LookupItem { Name = "pricelevelid", Value = "Kentico USD - 2020/07/01", Index = 0 });

            ObjectRepository.XrmApp.Entity.SetValue(new LookupItem { Name = "ken_purchaseraccountid", Value = "Test 2", Index = 0 });

            ObjectRepository.XrmApp.Entity.SetValue(new LookupItem { Name = "customerid", Value = "Test 2", Index = 0 });

            ObjectRepository.XrmApp.Entity.SetValue(new LookupItem { Name = "ken_deliverycontact", Value = "jan", Index = 0 });
            
            ObjectRepository.XrmApp.CommandBar.ClickCommand("Save");

            ObjectRepository.XrmApp.Entity.SubGrid.GetSubGridItems("salesorderdetailsGrid");
                        
            ObjectRepository.XrmApp.Entity.SubGrid.ClickCommand("salesorderdetailsGrid","Add Product");

            //ObjectRepository.XrmApp.CommandBar.GetCommandValues();

            //NavigationHelper.SignOut();
        }

        

        [TestMethod]
        public void OpenDynamicsPageWithBrowser()
        {
            var url = ObjectRepository.FromAppConfig.GetCrmUrl();
            var password = ObjectRepository.FromEnviron.GetCrmPassword();
            var username = ObjectRepository.FromEnviron.GetCrmUsername();
            var browser = ObjectRepository.XrmBrowser;

            
            browser.LoginPage.Login(url, username, password); 
                        
            browser.ThinkTime(5000);
            //browser.GuidedHelp.CloseGuidedHelp();
            //browser.Driver.FindElement(By.Id("AppTileContainerSec_1_LI_5")).Click();
            browser.Navigation.OpenApp("Kentico CRM App");
            browser.Navigation.OpenSubArea("Sales", "Orders");

            browser.Navigation.SignOut();
            browser.Driver.Quit();

            //var areas = browser.Navigation.GetAreas();     
            

        }
        public static void ADFSLoginAction(LoginRedirectEventArgs args)
        {



        }
    }

}
