using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _37_Using_jQuery_in_MVC.Models;
using Newtonsoft.Json;

namespace _37_Using_jQuery_in_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetStudent()
        {
            Student std = new Student()
            {
                Id=1,
                Name="Usama Bin Amjad",
                Email ="Usama88617@outlook.com"
            };
            var json = JsonConvert.SerializeObject(std);
            return Json(json,JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult AddStudent(Student student)
        {
            return Json("true", JsonRequestBehavior.AllowGet);
        }
       
    }
}