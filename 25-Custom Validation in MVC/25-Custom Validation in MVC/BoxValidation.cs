using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _25_Custom_Validation_in_MVC
{
    public class BoxValidation :  ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,ValidationContext validationContext)
        {
            if (value != null)
            {
                string message = value.ToString();
                if (message.Contains("Box"))
                {
                    return ValidationResult.Success;
                }
            }
            ErrorMessage = ErrorMessage ?? validationContext.DisplayName + "Field must contain Required";
            return new ValidationResult(ErrorMessage);
        }


    }
}