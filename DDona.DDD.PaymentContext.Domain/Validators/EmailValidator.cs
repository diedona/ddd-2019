using DDona.DDD.PaymentContext.Domain.ValueObjects;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Validators
{
    public class EmailValidator : AbstractValidator<Email>
    {
        public EmailValidator()
        {
            RuleFor(x => x.Address)
                .NotEmpty().WithMessage("Missing email.")
                .EmailAddress().WithMessage("Invalid email!");
        }
    }
}
