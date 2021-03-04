using SeleniumWebdriver.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.ComponentHelper
{
    internal class MappingsFactory
    {
        public Dictionary<string, object> Create<T>(T page)
        {
            var pageType = page.GetType();

            if (pageType.Equals(typeof(OrderPage)))
            {
                var orderPage = page as OrderPage;
                return new Dictionary<string, object>
                {
                //Order entity
                    {"Name", orderPage.Name},
                    {"Moved From", orderPage.MovedFrom},
                    {"Billing Office", orderPage.BillingOfficeType},
                    {"Deal",  orderPage.DealId},
                    {"Price List", orderPage.PriceLevel},
                    {"Purchaser",  orderPage.Purchaser},
                    {"Customer",  orderPage.Customer },
                    {"Delivery Contact", orderPage.DeliveryContact},
                    {"Status Reason", orderPage.StatusReason}

                };
            }
            else if (pageType.Equals(typeof(ProductPage)))
            {
                var productPage = page as ProductPage;
                return new Dictionary<string, object>
                {
                //product entity
                    {"Existing Product", productPage.ExistingProduct},
                    {"Pricing", productPage.Pricing},
                    {"Quantity", productPage.Quantity}
                };

            }
            else
                throw new TypeLoadException("No such type");
        }
        
    }
}
