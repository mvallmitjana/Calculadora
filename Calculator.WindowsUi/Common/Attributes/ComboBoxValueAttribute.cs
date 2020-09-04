using System.ComponentModel.DataAnnotations;

namespace Calculator.WindowsUi.Common.Attributes
{
    public class ComboBoxValueAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is int) // check if it is a valid integer
            {
                var suppliedValue = (int)value;
                if (suppliedValue < -1 || suppliedValue == 0)
                {
                    // let the user know about the validation error
                    return new ValidationResult("Debe seleccionar un elemento válido");
                }
            }

            return ValidationResult.Success;
        }
    }
}
