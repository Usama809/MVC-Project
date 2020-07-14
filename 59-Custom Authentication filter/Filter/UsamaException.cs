using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _59_Custom_Authentication_filter.Filter
{
    public class UsamaException : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (filterContext.Exception is NotImplementedException)
            {

            }
            else if(filterContext.Exception is DivideByZeroException)
            {

            }
            filterContext.Result = new ViewResult()
            {
                ViewName = "Error"
            };
            filterContext.ExceptionHandled = true;


        }
    }
}