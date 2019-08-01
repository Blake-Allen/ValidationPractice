using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.AspNetCore.Mvc.DataAnnotations.Internal;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValidationPractice.ValidationObjects
{
    public class CustomValidationAttrAdapterProvider : IValidationAttributeAdapterProvider
    {
        IValidationAttributeAdapterProvider baseProvider =
            new ValidationAttributeAdapterProvider();
        public IAttributeAdapter GetAttributeAdapter(ValidationAttribute attribute,
            IStringLocalizer stringLocalizer)
        {
            if (attribute is LastNameNotDavis)
            {
                return new LastNameNotDavisAdapter(
                    attribute as LastNameNotDavis, stringLocalizer);
            }
            else
            {
                return baseProvider.GetAttributeAdapter(attribute, stringLocalizer);
            }
        }
    }
}
