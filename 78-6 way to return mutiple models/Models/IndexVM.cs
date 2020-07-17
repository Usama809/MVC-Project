using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _78_6_way_to_return_mutiple_models.Models
{
    public class IndexVM
    {
        public List<Employee> Employees { get; set; }

        public List<Student> Students{ get; set; }
    }
}