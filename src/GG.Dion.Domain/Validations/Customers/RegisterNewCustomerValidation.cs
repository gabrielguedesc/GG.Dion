namespace GG.Dion.Domain.Validations.Customers
{
    public class RegisterNewCustomerValidation : CustomerValidations
    {
        public RegisterNewCustomerValidation()
        {
            ValidateId();
            ValidateName();
            ValidateEmail();
            ValidateBirthDate();
        }
    }
}
