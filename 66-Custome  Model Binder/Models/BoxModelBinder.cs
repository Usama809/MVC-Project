using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace _66_Custome__Model_Binder.Models
{
    public class BoxModelBinder : System.Web.Mvc.IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext)
        {
            var request = controllerContext.HttpContext.Request;
            var values = request.Headers.GetValues("BoxGentle");
            return JsonConvert.DeserializeObject<Employee>(values.First());
        }
    }
}