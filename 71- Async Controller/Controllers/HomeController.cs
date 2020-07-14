using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace _71__Async_Controller.Controllers
{
    public class HomeController : Controller
    {
        Sample1Entities db = new Sample1Entities();
        // GET: Home
        
        public async Task<ActionResult> Index()
        {
            var list = await db.Employee.ToListAsync();

            return View(list);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(Employee employee)
        {
            if(ModelState.IsValid)
            {
                db.Employee.Add(employee);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}