using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _78_6_way_to_return_mutiple_models.Models;
namespace _78_6_way_to_return_mutiple_models.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //var Student = GetStudents();
            //var Employee = GetEmployees();
            //View Model
            //IndexVM model = new IndexVM();
            //model.Students = Student;
            //model.Employees = Employee;

            //Dynamic Model
            //dynamic model = new ExpandoObject();
            //model.Employees = Employee;
            //model.Students = Student;
            //model.Name = "Umer";

            //Tuples
            //var model = new Tuple<List<Employee>, List<Student>, String>(Employee, Student, "Box");
            //ViewBag

            //ViewBag.Employees = Employee;
            //ViewBag.Students = Student;

            //View Data
            //ViewData["Emploees"] = Employee;
            //ViewData["Students"] = Student;



            return View();
        }
        public PartialViewResult Employee()
        {
            var Employee = GetEmployees();
            return PartialView("_EmployeeData", Employee);
        }

        public PartialViewResult Student()
        {
            var Student = GetStudents();
            return PartialView("_StudentData", Student);
        }
        private List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee(){Id=1, Name = "Usama", Email="Usama@gmail.com"},
                new Employee(){Id=1, Name = "Zain", Email="Zain@gmail.com"},
                new Employee(){Id=1, Name = "Muheeb", Email="Muheeb@gmail.com"}
            };
        }
        private List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student(){Id=1, Name = "jhon", Email="jhon@gmail.com"},
                new Student(){Id=1, Name = "MArk", Email="Mark@gmail.com"},
                new Student(){Id=1, Name = "Duo", Email="Duo@gmail.com"}
            };
        }
    }
}