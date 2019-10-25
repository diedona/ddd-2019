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
            this.ValidateEmailAddress();
        }

        public string Address { get; private set; }

        private void ValidateEmailAddress()
        {
            if(!this.Address.Contains("@"))
            {
                this.AddNotification("Address", "Invalid email!");
            }
        }
    }
}
