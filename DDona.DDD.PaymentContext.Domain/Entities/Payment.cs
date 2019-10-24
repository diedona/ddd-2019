using DDona.DDD.PaymentContext.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Entities
{
    public abstract class Payment : IPayment
    {
        protected Payment(DateTime paidDate, DateTime expiredDate, decimal total, decimal totalPaid, Payer payer)
        {
            Number = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0,10).ToUpper();
            PaidDate = paidDate;
            ExpiredDate = expiredDate;
            Total = total;
            TotalPaid = totalPaid;
            Payer = payer;
        }

        public string Number { get; private set; }
        public DateTime PaidDate { get; private set; }
        public DateTime ExpiredDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public Payer Payer { get; private set; }
    }
}
