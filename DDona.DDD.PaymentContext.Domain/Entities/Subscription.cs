using DDona.DDD.PaymentContext.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Entities
{
    public class Subscription : Entity
    {
        private IList<Payment> _payments;

        public Subscription(DateTime? expireDate)
        {
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            ExpireDate = expireDate;
            Active = true;
            _payments = new List<Payment>();
        }

        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public bool Active { get; private set; }
        public IReadOnlyCollection<Payment> Payments { get { return _payments.ToArray(); } }

        public void SetInactive()
        {
            this.Active = false;
            this.LastUpdateDate = DateTime.Now;
        }

        public void SetActive()
        {
            this.Active = true;
            this.LastUpdateDate = DateTime.Now;
        }

        public void AddPayment(Payment payment)
        {
            if(payment.PaidDate.Date < DateTime.Now.Date)
            {
                AddNotification("Subscription.Payments", "Payment can't be in the past!");
            }

            _payments.Add(payment);
        }
    }
}
