using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _48_OutputCache_Filter.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(Duration = 20, Location = System.Web.UI.OutputCacheLocation.Any)]
        public ActionResult GetDate()
        {
            return View();
        }
        [OutputCache(Duration = 20)]
        public int  GetTime()
        {
            return DateTime.Now.Day;
        }
        
    }
}