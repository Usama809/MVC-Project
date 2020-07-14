using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _17_HTTP_Verbs.Models;

namespace _17_HTTP_Verbs.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        //Get Data 
        public ActionResult Profile(int id)
        {
            return View();
        }
        [HttpPost]
        //Add New Data 
        public ActionResult CreateProfile(Student student)
        {
            return View();
        }
        //Change the record on databaSe 
        [HttpPut]
        public ActionResult UpdateProfile(int Id, Student student)
        {
            return View();
        }
        [HttpDelete]
        //Softdelete -> Active or Deactive
        //HardDelete -> Data Deleted parmanent on table
        public ActionResult DeleteProfile(int Id)
        {
            return View();
        }
      


    }
}