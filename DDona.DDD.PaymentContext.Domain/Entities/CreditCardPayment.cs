using DDona.DDD.PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(
            DateTime paidDate, 
            DateTime expiredDate, 
            decimal total, 
            decimal totalPaid, 
            Payer payer, 
            string cardHolderName, 
            string cardNumber, 
            string lastTransactionNumber) : base(paidDate, expiredDate, total, totalPaid, payer)
        {
            this.CardHolderName = cardHolderName;
            this.CardNumber = cardNumber;
            this.LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
    }
}
