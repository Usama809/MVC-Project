using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5_Controller.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from webgentle";
        }
        public string Home()
        {
            return "My Name is Usama";
        }

    }
}