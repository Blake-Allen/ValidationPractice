using Microsoft.AspNetCore.Mvc.DataAnnotations.Internal;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidationPractice.ValidationObjects
{
    public class LastNameNotDavisAdapter: AttributeAdapterBase<LastNameNotDavis>
    {
        public LastNameNotDavisAdapter(LastNameNotDavis attr, IStringLocalizer stringLocalizer): base(attr, stringLocalizer)
        {
        }
        public override void AddValidation(ClientModelValidationContext context)
        {
            if(context == null)
            {
                throw new NullReferenceException(nameof(context));
            }
            MergeAttribute(context.Attributes, "data-val", "true");
            MergeAttribute(context.Attributes, "data-val-lastNameNotDavis", GetErrorMessage(context));
        }
        public override string GetErrorMessage(ModelValidationContextBase validationContext)
        {
            return Attribute.GetErrorMessage();
        }
    }
}
