using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _19_Traditional_Routing.Models;
namespace _19_Traditional_Routing.Controllers
{
    public class StudentController : Controller
    {
        // GET: Home
        public ActionResult GetAllStudents()
        {
            var students = Students();

            return View(students);
        }
        public ActionResult GetStudent(int id)
        {
            var student = Students().FirstOrDefault(x=>x.Id == id); 
            return View(student);
        }
        public ActionResult GetStudentAddress(int id)
        {
            var studentAddress = Students().Where(x => x.Id == id).Select(x => x.Address).FirstOrDefault();
            return View(studentAddress);
        }
        private List<Student> Students()
        {
            return new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Name="1 Usama",
                    Class="First",
                    Address = new Address()
                    {
                      Address1 ="This is Student 1 Address",
                      City="Studnet 1 City",
                      HomeNumber="Student 1",
                    }

                 },
                 new Student()
                {
                    Id = 2,
                    Name="2 Zain",
                    Class="Second",
                    Address = new Address()
                    {
                      Address1 ="This is Student 2 Address",
                      City="Studnet 2 City",
                      HomeNumber="Student 2",
                    }

                 },
                  new Student()
                {
                    Id = 3,
                    Name="3 Muheeb",
                    Class="Third",
                    Address = new Address()
                    {
                      Address1 ="This is Student 3 Address",
                      City="Studnet 3 City",
                      HomeNumber="Student 3",
                    }

                 },
                  new Student()
                {
                    Id = 4,
                    Name="4 Muheeb",
                    Class="Fourth",
                    Address = new Address()
                    {
                      Address1 ="This is Student 4 Address",
                      City="Studnet 4 City",
                      HomeNumber="Student 4",
                    }

                 },
                new Student()
                {
                    Id = 5,
                    Name="5 Adeel",
                    Class="Five",
                    Address = new Address()
                    {
                      Address1 ="This is Student 5 Address",
                      City="Studnet 5 City",
                      HomeNumber="Student 5",
                    }
                 },
                 new Student()
                {
                    Id = 6,
                    Name="6 Azam",
                    Class="Six",
                    Address = new Address()
                    {
                      Address1 ="This is Student 6 Address",
                      City="Studnet 6 City",
                      HomeNumber="Student 6",
                    }
                 },
                  new Student()
                {
                    Id = 7,
                    Name="7 Nabeel",
                    Class="Seven",
                    Address = new Address()
                    {
                      Address1 ="This is Student 7 Address",
                      City="Studnet 7 City",
                      HomeNumber="Student 7",
                    }
                 },
            };
        }
        
    }
}