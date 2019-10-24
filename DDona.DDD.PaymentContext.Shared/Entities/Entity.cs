using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Shared.Entities
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}
