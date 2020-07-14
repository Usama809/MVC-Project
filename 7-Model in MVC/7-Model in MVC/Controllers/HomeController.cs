﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _7_Model_in_MVC.Models;
namespace _7_Model_in_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var data = GetEmployee();
            return View(data);
        }
        private Employee GetEmployee()
        {
            return new Employee()
            {
                Id = 1,
                Address = "Pakistan",
                Name = "Usama"
            };
        }
    }
}