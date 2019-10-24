using DDona.DDD.PaymentContext.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Entities
{
    public abstract class Payment : IPayment
    {
        public string Number { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
    }
}
