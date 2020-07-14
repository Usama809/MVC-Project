using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _21_Pass_Data_From_View_to_Contolller.Models;

namespace _21_Pass_Data_From_View_to_Contolller.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string PostUsingParameters(string firstName,string lastName)
        {
            return "From Parameters - " + firstName + "," + lastName;
        }
        [HttpPost]
        public string PostUsingRequest()
        {
            string firstName = Request ["firstName"];
            string lastName = Request ["lastName"];

            return "From Request - " + firstName + "," + lastName;
        }
        public string PostUsingFormCollection(FormCollection form)
        {
            string firstName = form["firstName"];
            string lastName = form["lastName"];

            return "From form Collection - " + firstName + "," + lastName;
        }
        public string PostUsingBinding(Employee emp)
        {
            return "From Strongly binding - " + emp.firstName + "," + emp.lastName;
        }
       
    }
}