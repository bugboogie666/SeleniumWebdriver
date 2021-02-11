using Microsoft.Dynamics365.UIAutomation.Api.UCI;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.PageObject
{
    class OrderPage
    {
        internal void FillForm()
        {
            ObjectRepository.XrmApp.Entity.SetValue("name", "hellofromselenium");
            ObjectRepository.XrmApp.Entity.SetValue("dyn_dealid", "898");

            ObjectRepository.XrmApp.Entity.SetValue(new OptionSet { Name = "ken_movedfrom", Value = "Perpetual" });


            ObjectRepository.XrmApp.Entity.SetValue(new OptionSet { Name = "ken_billingofficetype", Value = "Kentico Software Ltd - UK Office" });

            ObjectRepository.XrmApp.Entity.SetValue(new OptionSet { Name = "ken_movedfrom", Value = "Perpetual" });

            ObjectRepository.XrmApp.Entity.SetValue(new LookupItem { Name = "pricelevelid", Value = "Kentico USD - 2020/07/01", Index = 0 });

            ObjectRepository.XrmApp.Entity.SetValue(new LookupItem { Name = "ken_purchaseraccountid", Value = "Test 2", Index = 0 });

            ObjectRepository.XrmApp.Entity.SetValue(new LookupItem { Name = "customerid", Value = "Test 2", Index = 0 });

            ObjectRepository.XrmApp.Entity.SetValue(new LookupItem { Name = "ken_deliverycontact", Value = "jan", Index = 0 });
        }

        internal ProductPage AddProduct(string productName)
        {
            ObjectRepository.XrmApp.Entity.SubGrid.ClickCommand("salesorderdetailsGrid", "Add Product");
            return new ProductPage(productName);
        }

        internal void Save()
        {
            ObjectRepository.XrmApp.CommandBar.ClickCommand("Save");
        }
    }
}
