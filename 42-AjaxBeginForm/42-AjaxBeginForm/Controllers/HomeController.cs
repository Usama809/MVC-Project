using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _42_AjaxBeginForm.Models;
using Newtonsoft.Json;    
namespace _42_AjaxBeginForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Index(Employee model)
        {
            return Json("true",JsonRequestBehavior.AllowGet);
        }
        public ActionResult List()
        {
            return View();
        }
        public JsonResult Countries()
        {
            List<string> countries = new List<string>()
            {
                "Pakistan",
                "India",
                "China",
                "Angola",
                "Bahrain",
                "Barbados",
                "UAE",
                "SAUDIA ARABIA",
                "Australia",
                "Albania",

            };
            var json = JsonConvert.SerializeObject(countries);
            return Json(json, JsonRequestBehavior.AllowGet);
        }
        public JsonResult States()
        {
            List<string> states = new List<string>
              {
                "state -- Pakistan",
                "state -- India",
                "state -- China",
                "state -- Angola",
                "state -- Bahrain",
                "state -- Barbados",
                "state -- UAE",
                "state -- SAUDIA ARABIA",
                "state -- Australia",
                "state -- Albania",

            };
            var json = JsonConvert.SerializeObject(states);
            return Json(json, JsonRequestBehavior.AllowGet);
        }
        public JsonResult City()
        {
            List<string> city = new List<string>
              {
                "city -- -- Pakistan",
                "city -- -- India",
                "city -- -- China",
                "city -- -- Angola",
                "city -- -- Bahrain",
                "city -- -- Barbados",
                "city -- -- UAE",
                "city ---- SAUDIA ARABIA",
                "city -- -- Australia",
                "city -- -- Albania",

            };
            var json = JsonConvert.SerializeObject(city);
            return Json(json, JsonRequestBehavior.AllowGet);
        }

    };
}