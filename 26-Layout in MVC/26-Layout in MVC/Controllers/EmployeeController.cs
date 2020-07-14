using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _26_Layout_in_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [Route("Employee")]
        public ActionResult GetList()
        {
            return View("GetList", "_Layout");
        }
        [Route("NewEmployee")]
        public ActionResult AddEmployee()
        {
            return View("AddEmployee","_Layout");
        }
    }
}