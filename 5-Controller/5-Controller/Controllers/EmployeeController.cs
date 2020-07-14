using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5_Controller.Controllers
{
    public class EmployeeController : Controller
    {
        //Single Parameter
        //public string  EmployeeProfile(int id)
        //{
        //    string profile = string.Empty;

        //    if(id == 1)
        //    {
        //        profile= "Employee 1 profile";
        //    }
        //    else if(id == 2)
        //    {
        //        profile = "Employee 2 profile";
        //    }
        //    else
        //    {
        //        profile = "No Record Found";    
        //    }
        //    return "Profile";
        //}
        //Double Parameter
        //public string Address(int id, string department)
        //{
        //    return "id = " + id + "dept = " + department;
        //}
        //NullAble Parameter
        public string Address(int id, int? code = null)
        {
            return "id = " + id + "code = " + code;
        }
    }
}