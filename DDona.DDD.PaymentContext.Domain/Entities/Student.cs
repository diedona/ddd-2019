using DDona.DDD.PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Entities
{
    public class Student
    {
        private IList<Subscription> _subscriptions;

        public Student(Name name, Document document, string email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions
        {
            get { return _subscriptions.ToArray(); }
        }

        public void AddSubscription(Subscription subscription)
        {
            // cant add inactive subscription
            if (!subscription.Active)
            {
                throw new Exception("Subscription is inactive!");
            }

            // cancel all current subscriptions
            foreach (var sub in this.Subscriptions)
            {
                sub.SetInactive();
            }

            // add current active
            _subscriptions.Add(subscription);
        }
    }
}
