using Microsoft.Dynamics365.UIAutomation.Api.UCI;
using SeleniumWebdriver.ComponentHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.PageObject
{
    internal class ProductPage: PageObjectHelper
    {
        public string ProductName { get; set; }

        public LookupItem ExistingProduct => new LookupItem { Name = "productid" };
        public ProductPage(string productName=null)
        {
            var factory = new MappingsFactory();
            LabelToFieldMappings = factory.Create(this);
            ProductName = productName;
        }

        internal void SetPrice(decimal price)
        {
            throw new NotImplementedException();
        }
    }
}
