using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _45_Partial_View.Models;
namespace _45_Partial_View.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee()
                {
                    Id= 1,
                    Email = "UsamabinAmjad@gmail.com",
                    Name ="USama",
                    Description ="Hi i am new here and i am also live in pakistan",
                },
                new Employee()
                {
                    Id= 2,
                    Email = "UmerbinAmjad@gmail.com",
                    Name ="Umer",
                    Description ="Hi i am new here and i am also live in lahore",
                },
                new Employee()
                {
                    Id= 3,
                    Email = "RaisbinAmjad@gmail.com",
                    Name ="Rais",
                    Description ="Hi i am new here and i am also live in islamabad",
                },
                new Employee()
                {
                    Id= 4,
                    Email = "Zain@gmail.com",
                    Name ="Zain",
                    Description ="Hi i am new here and i am also live in Multan",
                }
            };
            return View();
        }
       
    }
}