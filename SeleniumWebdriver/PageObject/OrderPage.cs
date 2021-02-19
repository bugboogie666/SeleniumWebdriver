using Microsoft.Dynamics365.UIAutomation.Api.UCI;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Pageobject;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.PageObject
{
    class OrderPage: PageObjectHelper
    {
        //OrderPage fields
        public string Name => "name";
        public OptionSet MovedFrom => new OptionSet { Name = "ken_movedfrom" };
        public string DealId => "dyn_dealid";
        public OptionSet BillingOfficeType => new OptionSet { Name = "ken_billingofficetype" };
        public LookupItem PriceLevel => new LookupItem { Name = "pricelevelid" };
        public LookupItem Purchaser => new LookupItem { Name = "ken_purchaseraccountid" };
        public LookupItem Customer => new LookupItem { Name = "customerid" };
        public LookupItem DeliveryContact => new LookupItem { Name = "ken_deliverycontact" };
        public string SalesOrderDetailsGrid => "salesorderdetailsGrid";

        public OrderPage()
        {
            var factory = new MappingsFactory();
            LabelToFieldMappings = factory.Create(this);
        }

        internal string GetName()
        {
            return ObjectRepository.XrmApp.Entity.GetValue(Name);
        }

        internal ProductPage AddProduct()
        {
            ObjectRepository.XrmApp.Entity.SubGrid.ClickCommand(SalesOrderDetailsGrid, "Add Product");
            return new ProductPage();
        }
        internal OrdersPage SaveAndClose()
        {
            //ObjectRepository.XrmApp.ThinkTime(5000);
            ObjectRepository.XrmApp.CommandBar.ClickCommand("Save & Close");
            return new OrdersPage();
        }

        internal Guid GetRecordId()
        {
            return ObjectRepository.XrmApp.Entity.GetObjectId();
        }
    }
}
