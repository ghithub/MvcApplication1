using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Core
{
    public class PropertyRegistrationModelBinder : DefaultModelBinder
    {
        protected override object GetPropertyValue(
            ControllerContext controllerContext,
            ModelBindingContext bindingContext,
            System.ComponentModel.PropertyDescriptor propertyDescriptor,
            IModelBinder propertyBinder)
        {
            if (propertyDescriptor.ComponentType == typeof(Property) || propertyDescriptor.ComponentType == typeof(Agent))
            {
                if (propertyDescriptor.Name == "Price" || propertyDescriptor.Name == "AnnualSales")
                {  
                    var price = bindingContext.ValueProvider.GetValue(bindingContext.ModelName).AttemptedValue;
                    return string.IsNullOrWhiteSpace(price)? null : (int?)Convert.ToInt32(price.Replace(",", string.Empty));
                }
            }

            return base.GetPropertyValue(controllerContext, bindingContext, propertyDescriptor, propertyBinder);
        }
    }
}

