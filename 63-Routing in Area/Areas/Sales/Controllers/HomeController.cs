using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _63_Routing_in_Area.Areas.Sales.Controllers
{
    public class HomeController : Controller
    {
        // GET: Sales/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}