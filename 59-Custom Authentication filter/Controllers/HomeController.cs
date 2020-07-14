using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _59_Custom_Authentication_filter.Filter;
namespace _59_Custom_Authentication_filter.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       //    [UsamaAuthentication]
       // [UsamaAction]
       [UsamaException]
        public ActionResult Index()
        {
            return View();
        }
    }
}