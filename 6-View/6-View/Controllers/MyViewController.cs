using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6_View.Controllers
{
    public class MyViewController : Controller
    {
        // GET: MyView
        public ActionResult Index()
        {
            return View();
        }
    }
}