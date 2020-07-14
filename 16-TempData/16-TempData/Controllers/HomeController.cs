using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_TempData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TempData["myKey"] = "Data from index methode";
            return View();
        }
        public ActionResult Index2()
        {
            Session.Abandon();
            ViewBag.Mykey = TempData.Peek("myKey");
            return View();
        }
        public ActionResult Index3()
        {
            ViewBag.Mykey = TempData["myKey"];
            TempData.Keep("myKey");
            return View();
        }
    }
}