using System.ComponentModel.DataAnnotations;

namespace Sequences
{
    public class PositiveIntegerAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var propertyInfo = validationContext.ObjectType.GetProperty(validationContext.MemberName);
            int number = (int) propertyInfo.GetValue(validationContext.ObjectInstance);

            if (number < 0)
            {
                return new ValidationResult($"{validationContext.DisplayName} must be a positive, whole number.");
            }

            return ValidationResult.Success;
        }
    }
}