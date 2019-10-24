using DDona.DDD.PaymentContext.Domain.Interfaces;
using DDona.DDD.PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment, IPaymentWithEmail
    {
        public BoletoPayment(
            DateTime paidDate, 
            DateTime expiredDate, 
            decimal total, 
            decimal totalPaid, 
            Payer payer, 
            string barCode, 
            Email email, 
            string boletoNumber) : base(paidDate, expiredDate, total, totalPaid, payer)
        {
            this.BarCode = barCode;
            this.Email = email;
            this.BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public Email Email { get; private set; }
        public string BoletoNumber { get; private set; }
    }
}
