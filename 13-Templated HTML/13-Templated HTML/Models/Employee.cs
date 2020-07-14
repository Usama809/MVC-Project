using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _13_Templated_HTML.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name="Zain Akram")]
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsOnline { get; set; }
        [Display(Name="Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [DataType(DataType.Time)]
        public DateTime BirthTime { get; set; }
    }
}