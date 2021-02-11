using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.PageObject
{
    internal class ProductPage
    {
        public string ProductName { get; set; }
        public ProductPage(string productName)
        {
            ProductName = productName;
        }

        internal void SetPrice(decimal price)
        {
            throw new NotImplementedException();
        }
    }
}
