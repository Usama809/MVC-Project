using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _50_Exception_Handling_Error.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
                throw new Exception("this is a exception");               
        }
        public ActionResult About()
        {
            throw new Exception("this is a exception");
        }
    }
}