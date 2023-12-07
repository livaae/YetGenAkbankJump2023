using FluentValidation;
using Week11.Domain.Entities;

namespace Week11.API.Models.Validators
{
    public class BankAccountValidator :AbstractValidator<BankAccount>
    {
        public BankAccountValidator()
        {
            RuleFor(x => x.FirstName).NotNull().NotEmpty().WithMessage("Please enter first name.");

            RuleFor(x => x.LastName).NotNull().WithMessage("Please enter last name.");

            RuleFor(x => x.PhoneNumber).NotNull().WithMessage("Please enter phone number.");

            RuleFor(x => x.Balance).NotNull().WithMessage("Please enter first name.");

            RuleFor(x => x.FirstName).MaximumLength(100).WithMessage("Enter maximum 100 characters.");

            RuleFor(x => x.PhoneNumber).MaximumLength(11).WithMessage("Enter maximum 11 characters.");
        }
    }
}
