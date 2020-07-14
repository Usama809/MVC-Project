using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _15_View_Bag_And_ViewData.Models;
namespace _15_View_Bag_And_ViewData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Code = "Google";
            ViewBag.MyList = new List<string> { "Usama", "Zain", "Umer", "Muheeb" };
            //Employee List
            List<Employee> empList = new List<Employee>()
            {
                  new Employee(){Email="U@s.com", ID = 1,Name = "Usama"},
                  new Employee(){Email="Z@s.com", ID = 2,Name = "Zain"},
                  new Employee(){Email="O@s.com", ID = 3,Name = "Umer"},

            };
            ViewBag.MyEmpList = empList;

            return View();
        }

        public ActionResult Demo()
        {
            ViewData["MyKey"] ="This is my key";
            ViewData["MyList"] = new List<string> { "Usama", "Zain", "Umer", "Muheeb" };
            return View();
        }
    }

}