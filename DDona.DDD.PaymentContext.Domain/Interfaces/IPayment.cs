using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Interfaces
{
    public interface IPayment
    {
        string Number { get; }
        DateTime PaidDate { get; }
        DateTime ExpiredDate { get; }
        decimal Total { get; }
        decimal TotalPaid { get; }
    }
}
