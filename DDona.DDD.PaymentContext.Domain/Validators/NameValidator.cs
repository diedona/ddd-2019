using DDona.DDD.PaymentContext.Domain.ValueObjects;
using DDona.DDD.PaymentContext.Shared.ValueObjects;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Validators
{
    public class NameValidator : AbstractValidator<Name>
    {
        public NameValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name required!");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name required!");
        }
    }
}
