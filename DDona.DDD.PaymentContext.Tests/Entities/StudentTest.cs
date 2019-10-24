using DDona.DDD.PaymentContext.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DDona.DDD.PaymentContext.Tests.Entities
{
    public class StudentTest
    {
        [Fact]
        public void Should_Fail_Add_Inactive_Subscription()
        {
            var student = new Student("Diego", "Doná", "123123123", "diedona@gmail.com");
            var subscription = new Subscription(null);
            subscription.SetInactive();
            Assert.Throws<Exception>(() => student.AddSubscription(subscription));
        }

        [Fact]
        public void Should_Success_Add_Active_Subscription()
        {
            var student = new Student("Diego", "Doná", "123123123", "diedona@gmail.com");
            var subscription = new Subscription(null);
            student.AddSubscription(subscription);
        }
    }
}
