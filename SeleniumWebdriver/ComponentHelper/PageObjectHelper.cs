using Microsoft.Dynamics365.UIAutomation.Api.UCI;
using SeleniumWebdriver.PageObject;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.ComponentHelper
{
    internal abstract class PageObjectHelper
    {
        private protected Dictionary<string, object> LabelToFieldMappings { get; set; }


        internal void Fill(string label, object value, int index = 0)
        {
            var toResolve = GetFieldByLabel(label);
            var fieldType = toResolve.GetType();

            if (fieldType.Equals(typeof(string)))
            {
                ObjectRepository.XrmApp.Entity.SetValue(toResolve.ToString(), value.ToString());
            }
            else if (fieldType.Equals(typeof(OptionSet)))
            {
                var fieldRetyped = toResolve as OptionSet;
                ObjectRepository.XrmApp.Entity.SetValue(new OptionSet { Name = fieldRetyped.Name, Value = value.ToString() });
            }
            else if (fieldType.Equals(typeof(LookupItem)))
            {
                var fieldRetyped = toResolve as LookupItem;
                ObjectRepository.XrmApp.Entity.SetValue(new LookupItem { Name = fieldRetyped.Name, Value = value.ToString(), Index = index });
            }
            else if (fieldType.Equals(typeof(BooleanItem)))
            {
                var fieldRetyped = toResolve as BooleanItem;                
                ObjectRepository.XrmApp.Entity.SetValue(new BooleanItem { Name = fieldRetyped.Name, Value = Convert.ToBoolean(value) });
            }
            else
                throw new TypeLoadException();
        }
        internal object GetFieldByLabel(string label)
        {
            object result = null;
            foreach (var element in LabelToFieldMappings)
            {
                if (element.Key.Equals(label))
                {
                    result = element.Value;
                    break;
                }
            }
            return result;
        }
        internal void FillForm(Dictionary<string, object> data)
        {
            foreach (var element in data)
            {
                Fill(element.Key, element.Value);
            }
        }
        internal void Save()
        {
            ObjectRepository.XrmApp.CommandBar.ClickCommand("Save");
        }




    }
}
