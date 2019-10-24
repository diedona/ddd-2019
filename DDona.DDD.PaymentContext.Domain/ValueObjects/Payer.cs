using DDona.DDD.PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.ValueObjects
{
    public class Payer
    {
        public Payer(string name, Document document, string address)
        {
            Name = name;
            Document = document;
            Address = address;
        }

        public string Name { get; private set; }
        public Document Document { get; private set; }
        public string Address { get; private set; }
    }
}
