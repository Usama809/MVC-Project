using _68_Unit_Testing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _68_Unit_Testing.Models;

namespace _68_Unit_Testing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
                Id = 1,
                Name = "Usama"
            };
            
            return View("Index", emp);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}