using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Entities
{
    public abstract class Payer
    {
        public string Document { get; set; }
        public string Address { get; set; }
    }
}
