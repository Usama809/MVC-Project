﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL;
using Intuit.Ipp.Data;

namespace _69_Dependency_Injection.Controllers
{
    public class HomeController : Controller
    {
        private IEmployee _employee = null;
        private IStudent _student = null;
        public HomeController(IEmployee employee, IStudent student)
        {
            _employee = employee;
            _student = student;
        }

        public ActionResult Index()
        {
            int count = _employee.GetTotalStudents();
            bool data = _student.IsStudent();
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
    }
}