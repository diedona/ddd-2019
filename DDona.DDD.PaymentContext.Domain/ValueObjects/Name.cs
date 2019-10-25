using DDona.DDD.PaymentContext.Shared.ValueObjects;
using Flunt.Notifications;
using Flunt.Validations;
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

            AddNotifications(
                new Contract()
                .Requires().IsNotNullOrEmpty(FirstName, "Name.FirstName", "Invalid First Name")
                .Requires().IsNotNullOrEmpty(LastName, "Name.LastName", "Invalid Last Name")
            );
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
