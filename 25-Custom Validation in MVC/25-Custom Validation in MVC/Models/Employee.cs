using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace _25_Custom_Validation_in_MVC.Models
{
    public class Employee
    { 
        [Required]
        public string Name { get; set; }

        [BoxValidation]
        public string Message { get; set; }
    }
}