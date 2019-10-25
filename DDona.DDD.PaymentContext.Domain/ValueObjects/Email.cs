using DDona.DDD.PaymentContext.Shared.ValueObjects;
using Flunt.Validations;
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

            AddNotifications(
                new Contract()
                .Requires().IsEmail(Address, "Email.Address", "Invalid Email")
            );
        }

        public string Address { get; private set; }
    }
}
