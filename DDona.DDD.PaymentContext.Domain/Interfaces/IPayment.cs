using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Interfaces
{
    public interface IPayment
    {
        string Number { get; set; }
        DateTime PaidDate { get; set; }
        DateTime ExpiredDate { get; set; }
        decimal Total { get; set; }
        decimal TotalPaid { get; set; }
    }
}
