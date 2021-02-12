using Microsoft.Dynamics365.UIAutomation.Api.UCI;
using SeleniumWebdriver.ComponentHelper;
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

        internal ProductPage AddProduct(string productName)
        {
            ObjectRepository.XrmApp.Entity.SubGrid.ClickCommand(SalesOrderDetailsGrid, "Add Product");
            return new ProductPage(productName);
        }






    }
}
