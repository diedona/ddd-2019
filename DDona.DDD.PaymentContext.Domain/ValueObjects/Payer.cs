using DDona.DDD.PaymentContext.Domain.ValueObjects;
using DDona.DDD.PaymentContext.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.ValueObjects
{
    public class Payer : ValueObject
    {
        public Payer(string name, Document document, Address address)
        {
            Name = name;
            Document = document;
            Address = address;
        }

        public string Name { get; private set; }
        public Document Document { get; private set; }
        public Address Address { get; private set; }
    }
}
