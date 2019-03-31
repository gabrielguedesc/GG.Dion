using GG.Dion.Domain.Validations.Customers;
using System;

namespace GG.Dion.Domain.Entities
{
    public class Customer : Entity
    {
        public Customer(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public Customer(Guid id)
        {
            Id = id;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }

        public bool IsValidForNewRegister()
        {
            ValidationResult = new RegisterNewCustomerValidation().Validate(this);
            return ValidationResult.IsValid;
        }

        public bool IsValidForUpdate()
        {
            ValidationResult = new UpdateCustomerValidation().Validate(this);
            return ValidationResult.IsValid;
        }

        public bool IsValidForRemove()
        {
            ValidationResult = new RemoveCustomerValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
