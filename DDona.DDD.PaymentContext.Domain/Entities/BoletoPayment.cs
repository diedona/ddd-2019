using DDona.DDD.PaymentContext.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment, IPaymentWithEmail
    {
        public string BarCode { get; set; }
        public string Email { get; set; }
    }
}
