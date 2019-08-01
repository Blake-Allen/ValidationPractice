using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ValidationPractice.Models;

namespace ValidationPractice.ValidationObjects
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class LastNameNotDavis : ValidationAttribute, IClientModelValidator 
    {
        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-lastNameNotDavis", GetErrorMessage());
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var lastName = (FormViewModel)validationContext.ObjectInstance;
            if(lastName.FamilyName != null && lastName.FamilyName.ToLower() == "davis")
            {
                return new ValidationResult(GetErrorMessage());
            }
            return ValidationResult.Success;
        }

        internal string GetErrorMessage()
        {
            return "Last name cannot be Davis";
        }
    }
}
