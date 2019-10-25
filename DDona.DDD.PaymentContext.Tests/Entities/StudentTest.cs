using DDona.DDD.PaymentContext.Domain.Entities;
using DDona.DDD.PaymentContext.Domain.Enums;
using DDona.DDD.PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DDona.DDD.PaymentContext.Tests.Entities
{
    public class StudentTest
    {
        private readonly Document _document;
        private readonly Name _name;
        private readonly Email _email;
        private readonly Student _student;

        public StudentTest()
        {
            _document = new Document("84300569045", EDocumentType.CPF);
            _name = new Name("Diego", "Doná");
            _email = new Email("diedona@gmail.com");
            _student = new Student(_name, _document, _email);
        }

        [Fact]
        public void Should_Fail_Add_Inactive_Subscription()
        {
            var subscription = new Subscription(null);
            subscription.SetInactive();
            _student.AddSubscription(subscription);

            Assert.False(_student.Valid);
        }

        [Fact]
        public void Should_Success_Add_Active_Subscription()
        {
            var subscription = new Subscription(null);

            subscription.AddPayment(new CreditCardPayment(DateTime.Now, DateTime.Now.AddDays(1), 100, 100,
                new Payer(_name, _document, new Address()), "Diego Doná", "123", "0"));

            _student.AddSubscription(subscription);

            Assert.True(_student.Valid);
        }

        [Fact]
        public void Should_Faill_Add_Subscription_Without_Payment()
        {
            var subscription = new Subscription(null);
            _student.AddSubscription(subscription);

            Assert.False(_student.Valid);
        }

        [Fact]
        public void Should_Invalid_First_Name_Empty()
        {
            var student = new Student(new Name(string.Empty, "Doná"), new Document("123", EDocumentType.CPF), new Email("diedona@gmail.com"));
            Assert.False(student.Name.Valid);
        }

        [Fact]
        public void Should_Invalid_Email()
        {
            var student = new Student(new Name("Diego", "Doná"), new Document("123", EDocumentType.CPF), new Email("diedona"));
            Assert.False(student.Email.Valid);
        }
    }
}
