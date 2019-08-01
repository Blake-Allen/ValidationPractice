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
    public class FromDateAfterToDate : ValidationAttribute, IClientModelValidator
    {
        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-fromDateAfterToDate", GetErrorMessage());
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var vm = (FormViewModel)validationContext.ObjectInstance;
            var startDate = vm.StartDate;
            var endDate = vm.EndDate;
            if (startDate.HasValue && endDate.HasValue && startDate > endDate)
            {
                return new ValidationResult(GetErrorMessage());
            }
            return ValidationResult.Success;
        }
        internal string GetErrorMessage()
        {
            return "Start date cannot be after end date";
        }
    }
}
