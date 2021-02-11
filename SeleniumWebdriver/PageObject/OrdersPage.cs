using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.PageObject;
using SeleniumWebdriver.Settings;
using System;

namespace SeleniumWebdriver.Pageobject
{
    internal class OrdersPage
    {
        public OrdersPage()
        {
        }

        internal void Open()
        {
            NavigationHelper.NavigateToSubarea("Sales", "Orders");
        }

        internal OrderPage CreateOrder()
        {
            ObjectRepository.XrmApp.CommandBar.ClickCommand("New");
            return new OrderPage();
            
        }
    }
}