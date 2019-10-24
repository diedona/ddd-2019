using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Entities
{
    public class PayerFisico : Payer
    {
        public PayerFisico(string name, string document, string address) : base(name, document, address)
        {
        }

        protected override bool ValidateDocument()
        {
            if(this.Document.Length < 11)
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
