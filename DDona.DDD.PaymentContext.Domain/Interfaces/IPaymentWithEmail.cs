using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Interfaces
{
    public interface IPaymentWithEmail : IPayment
    {
        string Email { get; set; }
    }
}
