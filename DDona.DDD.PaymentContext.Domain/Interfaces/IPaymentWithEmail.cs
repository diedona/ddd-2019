using DDona.DDD.PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Interfaces
{
    public interface IPaymentWithEmail : IPayment
    {
        Email Email { get; }
    }
}
