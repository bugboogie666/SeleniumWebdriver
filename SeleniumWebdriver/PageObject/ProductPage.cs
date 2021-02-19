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
    internal class ProductPage: PageObjectHelper
    {
                       
        public LookupItem ExistingProduct => new LookupItem { Name = "productid" };
        public BooleanItem Pricing => new BooleanItem { Name = "ispriceoverridden" };
        
        public ProductPage()
        {
            var factory = new MappingsFactory();
            LabelToFieldMappings = factory.Create(this);            
        }   

        internal OrderPage SaveAndClose()
        {            
            ObjectRepository.XrmApp.CommandBar.ClickCommand("Save & Close");            
            return new OrderPage();
            
        }
    }
}
