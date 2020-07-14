using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _13_Templated_HTML.Models;

namespace _13_Templated_HTML.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
                Id = 1,
                Name = "Usama",
                DateOfBirth = DateTime.Now,
                Email = "MohammadOsama6666@gmail.com",
                IsOnline = true

            };
           
            return View(emp);
        }
        public ActionResult Edit()
        {
                return View();
        }
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            return View();
        }
            
    }
}