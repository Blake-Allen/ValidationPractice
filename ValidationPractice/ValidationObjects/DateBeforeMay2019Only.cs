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
    public class DateBeforeMay2019Only : ValidationAttribute, IClientModelValidator
    {
        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-dateBeforeMay2019", GetErrorMessage());
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var startDate = (FormViewModel)validationContext.ObjectInstance;
            var may2019 = new DateTime(2019, 5, 1);
            if (startDate.StartDate != null && startDate.StartDate.Value > may2019)
            {
                return new ValidationResult(GetErrorMessage());
            }
            return ValidationResult.Success;  
        }
        internal string GetErrorMessage()
        {
            return "Start date must be before May 2019";
        }
    }
}
