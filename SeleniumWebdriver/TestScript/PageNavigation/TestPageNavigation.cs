using System;
//using Microsoft.Dynamics365.UIAutomation.Api
using Microsoft.Dynamics365.UIAutomation.Api.UCI;
using Microsoft.Dynamics365.UIAutomation.Browser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Pageobject;
using SeleniumWebdriver.PageObject;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.PageNavigation
{
    [TestClass]
    public class TestPageNavigation
    {
    
 
        [TestMethod]
        public void ReinstatementShouldBeCreatedWhenOrderIsPaid3DaysAfterRenewalStartedDeprecated()
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
        public void ReinstatementShouldBeCreatedWhenOrderIsPaid3DaysAfterRenewalStarted()
        {
            var url = ObjectRepository.FromAppConfig.GetCrmUrl();
            var password = ObjectRepository.FromEnviron.GetCrmPassword();
            var username = ObjectRepository.FromEnviron.GetCrmUsername();

            //Login
            NavigationHelper.LoginAndOpenDynamicsApp("Kentico CRM App", url, username, password);
            //Create order
            OrdersPage ordersPage = new OrdersPage();            
            ordersPage.Open();
            OrderPage order = ordersPage.CreateOrder();            
            order.Fill("Name", "newmethod");
            order.Fill("Purchaser", "Test 2");
            order.Fill("Moved From", "Perpetual");
            //order.Save();
            //var product = order.AddProduct("Maintenace Renewal");
            //product.SetPrice(10000);            

        }
  
    }

}
