using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Entities
{
    public class PayerJuridico : Payer
    {
        public PayerJuridico(string name, string document, string address) : base(name, document, address)
        {
        }

        protected override bool ValidateDocument()
        {
            if(this.Document.Length < 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
