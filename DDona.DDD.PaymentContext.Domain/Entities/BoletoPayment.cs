using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Entities
{
    public class BoletoPayment
    {
        public string BarCode { get; set; }
        public string Email { get; set; }
    }
}
