using DDona.DDD.PaymentContext.Domain.ValueObjects;
using DDona.DDD.PaymentContext.Shared.Entities;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscriptions;

        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();

            this.AddNotifications(name, document, email);
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions
        {
            get { return _subscriptions.ToArray(); }
        }

        public void AddSubscription(Subscription subscription)
        {
            // cant add inactive subscription
            AddNotifications(new Contract().Requires()
                .IsTrue(subscription.Active, "Student.Subscription.Active", "Subscription is not active")
                .IsGreaterThan(subscription.Payments.Count, 0, "Student.Subscription.Payment", "Subscription has no payment")
            );

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
