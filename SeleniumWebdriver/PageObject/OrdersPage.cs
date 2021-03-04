using Microsoft.Dynamics365.UIAutomation.Api.UCI;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.PageObject;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;

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
            var commands = ObjectRepository.XrmApp.CommandBar.GetCommandValues();
            ObjectRepository.XrmApp.CommandBar.ClickCommand("New");
            return new OrderPage();            
        }

        internal bool RecordExists(OrderPage order, Guid id)
        {
            ObjectRepository.XrmApp.Grid.OpenRecord(0);
            //return order.GetName().Equals(orderName);
            return order.GetRecordId().Equals(id);
        }
    
    }
}