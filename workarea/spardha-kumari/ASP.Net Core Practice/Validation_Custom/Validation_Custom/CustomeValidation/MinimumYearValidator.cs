using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Xml.Schema;

namespace Validation_Custom.CustomeValidation
{
    public class MinimumYearValidator:ValidationAttribute
    {
        public int MinimumYear { get; set; } = 2000;
        public string DefaultMsg { get; set; } = "year should be greater than 2000";
        //Parameterless Constructor
        public MinimumYearValidator() { }

        public MinimumYearValidator(int minimumYear) {
            MinimumYear = minimumYear;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {


            if (value != null)
            {
                DateTime dt = (DateTime)value;
                if(dt.Year>=MinimumYear)
                {
                    return new ValidationResult(string.Format(ErrorMessage ?? DefaultMsg, MinimumYear));
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            return null;
        }

    }
}
