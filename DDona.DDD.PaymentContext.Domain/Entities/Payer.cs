using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Entities
{
    public abstract class Payer
    {
        protected Payer(string name, string document, string address)
        {
            Name = name;
            Document = document;
            Address = address;

            if(!ValidateDocument())
            {
                throw new Exception("Invalid document!");
            }
        }

        public string Name { get; private set; }
        public string Document { get; private set; }
        public string Address { get; private set; }

        protected abstract bool ValidateDocument();
    }
}
