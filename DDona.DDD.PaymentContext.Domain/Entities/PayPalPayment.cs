using DDona.DDD.PaymentContext.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment, IPaymentWithEmail
    {
        public string Email { get; set; }
    }
}
