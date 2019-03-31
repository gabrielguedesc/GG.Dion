namespace GG.Dion.Domain.Validations.Customers
{
    public class UpdateCustomerValidation : CustomerValidations
    {
        public UpdateCustomerValidation()
        {
            ValidateId();
            ValidateName();
            ValidateEmail();
            ValidateBirthDate();
        }
    }
}
