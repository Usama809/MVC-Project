using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace _74_Create_a_drop_Down_List.Models
{
    public class Employee
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Country { get; set; }

    }
}