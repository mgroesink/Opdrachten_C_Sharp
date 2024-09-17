using System;
using System.ComponentModel.DataAnnotations;

namespace Opdrachten_C_Sharp.Models
{
    public class NoFutureDate: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool isValid = true;
            DateTime? date = value as DateTime?;
            if(date > DateTime.Now)
            {
                ErrorMessage = "Datum mag niet in de toekomst liggen";
                isValid = false;
            }
            return isValid;
        }
    }
}
