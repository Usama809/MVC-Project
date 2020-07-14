using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _22_Validation_in_MVC_lossly_binding.Models
{
    public class Employee
    {
        [Required (ErrorMessage="Please Enter Your FirstName")]
        public string FirstName{ get; set; }
        [Required(ErrorMessage = "Please Enter Your Last Name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Range(18,100)]
        public int Age { get; set; }
    }
}