using FluentValidation;
using GG.Dion.Domain.Entities;
using System;

namespace GG.Dion.Domain.Validations.Customers
{
    public abstract class CustomerValidations : AbstractValidator<Customer>
    {
        protected void ValidateId()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty)
                .WithMessage("Id inválido.");
        }

        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("O nome é obrigatório.")
                .Length(3, 150).WithMessage("O nome deve ter entre 3 e 150 caracteres.");
        }

        protected void ValidateBirthDate()
        {
            RuleFor(c => c.BirthDate)
                .NotEqual(default(DateTime)).WithMessage("Idade inválida.")
                .Must(HaveMinimumAge).WithMessage("Idade mínima é 18 anos.");
        }

        protected void ValidateEmail()
        {
            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("O e-mail é obrigatório.")
                .EmailAddress().WithMessage("E-mail inválido");
        }

        private static bool HaveMinimumAge(DateTime birthDate)
        {
            return birthDate <= DateTime.Now.AddYears(-18);
        }
    }
}
