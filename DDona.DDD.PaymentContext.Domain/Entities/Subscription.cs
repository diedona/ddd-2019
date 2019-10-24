using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Entities
{
    public class Subscription
    {
        public Subscription(DateTime createDate, DateTime lastUpdateDate, bool active)
        {
            CreateDate = createDate;
            LastUpdateDate = lastUpdateDate;
            Active = active;
        }

        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public bool Active { get; private set; }

        public void SetInactive()
        {
            this.Active = false;
        }
    }
}
