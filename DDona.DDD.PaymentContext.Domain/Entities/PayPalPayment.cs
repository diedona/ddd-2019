using DDona.DDD.PaymentContext.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment, IPaymentWithEmail
    {
        public PayPalPayment(
            DateTime paidDate, DateTime expiredDate, 
            decimal total, decimal totalPaid, 
            Payer payer, string transactionCode, 
            string email) : base(paidDate, expiredDate, total, totalPaid, payer)
        {
            this.TransactionCode = transactionCode;
            this.Email = email;
        }

        public string TransactionCode { get; private set; }
        public string Email { get; private set; }
    }
}
