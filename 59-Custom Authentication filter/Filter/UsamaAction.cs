using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _59_Custom_Authentication_filter.Filter
{
    public class UsamaAction : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("Hello from action Filter OnActionExecuted"); 
            filterContext.Controller.ViewBag.Message = "Usama form action Filter";
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("Hello from action Filter OnActionExecuting");
           
        }
    }
}