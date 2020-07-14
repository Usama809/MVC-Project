using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _74_Create_a_drop_Down_List.Models;
namespace _74_Create_a_drop_Down_List.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Test()
        {
            var countries = new List<Country>()
            {
                new Country (){ Id = 1, Text ="India"},
                new Country (){ Id = 2, Text ="Japan"},
                new Country (){ Id = 3, Text ="Koria"},
                new Country (){ Id = 4, Text ="Pakistan"},
            };
            //var list = new List<string>() { "India", "Pakitsan", "chine", "America" };
            //ViewBag.list = list;

            Employee emp = new Employee()
            {
                Country = 1
            };
            return View(emp);
        }
        [HttpPost]
        public ActionResult Test(Employee emp)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Test");
            }
            var countries = new List<Country>()
            {
                new Country (){ Id = 1, Text ="India"},
                new Country (){ Id = 2, Text ="Japan"},
                new Country (){ Id = 3, Text ="Koria"},
                new Country (){ Id = 4, Text ="Pakistan"},
            };
            //var list = new List<string>() { "India", "Pakitsan", "chine", "America" };
            //ViewBag.list = list;
            return View();
            
        }
        class Country
        {
            public int Id { get; set; }
            public string Text { get; set; }
        }
    }
}