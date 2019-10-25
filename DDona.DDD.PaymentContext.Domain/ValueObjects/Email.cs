using DDona.DDD.PaymentContext.Domain.Validators;
using DDona.DDD.PaymentContext.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;

            Validate(this, new EmailValidator());
        }

        public string Address { get; private set; }
    }
}
