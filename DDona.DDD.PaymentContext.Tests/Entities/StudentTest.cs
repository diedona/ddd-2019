﻿using DDona.DDD.PaymentContext.Domain.Entities;
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
        [Fact]
        public void Should_Fail_Add_Inactive_Subscription()
        {
            var student = new Student(new Name("Diego", "Doná"), 
                new Document("123123123", EDocumentType.CPF), 
                new Email("diedona@gmail.com"));
            var subscription = new Subscription(null);
            subscription.SetInactive();
            Assert.Throws<Exception>(() => student.AddSubscription(subscription));
        }

        [Fact]
        public void Should_Success_Add_Active_Subscription()
        {
            var student = new Student(new Name("Diego", "Doná"), 
                new Document("123123123", EDocumentType.CPF), 
                new Email("diedona@gmail.com"));
            var subscription = new Subscription(null);
            student.AddSubscription(subscription);
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
