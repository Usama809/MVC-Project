using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _12_Strongly_Type_HTML_Helper.Models;
namespace _12_Strongly_Type_HTML_Helper.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
                Name = "Usama",
                Address="This is my first Address",
                IsEmployee=true
            };
            return View(emp);
        }
        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            return View();
        }
    }
}