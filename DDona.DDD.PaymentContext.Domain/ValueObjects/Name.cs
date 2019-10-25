using DDona.DDD.PaymentContext.Domain.Validators;
using DDona.DDD.PaymentContext.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            Validate(this, new NameValidator());
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
