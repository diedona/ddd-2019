using DDona.DDD.PaymentContext.Domain.Entities;
using DDona.DDD.PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DDona.DDD.PaymentContext.Tests.Entities
{
    public class SubscriptionTest
    {
        private readonly Name name = new Name("Ademilson", "Almeida");

        [Fact]
        public void Should_Invalid_Payment_Past_Date()
        {
            Subscription subscription = new Subscription(null);
            subscription.AddPayment(new BoletoPayment(DateTime.Now.AddDays(-1), DateTime.Now.AddDays(15), 100, 100,
                new Payer(this.name, new Document("12345678978", Domain.Enums.EDocumentType.CPF), new Address()),
                "123", new Email("asd@asd.com"), "11114444"
            ));

            Assert.False(subscription.Valid);
        }

        [Fact]
        public void Should_Valid_Payment()
        {
            Subscription subscription = new Subscription(null);
            subscription.AddPayment(new BoletoPayment(DateTime.Now, DateTime.Now.AddDays(15), 100, 100,
                new Payer(this.name, new Document("12345678978", Domain.Enums.EDocumentType.CPF), new Address()),
                "123", new Email("asd@asd.com"), "11114444"
            ));

            Assert.True(subscription.Valid);
        }
    }
}
