using DDona.DDD.PaymentContext.Domain.Enums;
using DDona.DDD.PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DDona.DDD.PaymentContext.Tests.ValueObjects
{
    public class DocumentTest
    {
        [Fact]
        public void Should_Fail_Invalid_Length_CPF()
        {
            Document document = new Document("123", EDocumentType.CPF);
            Assert.False(document.Valid);
        }

        [Fact]
        public void Should_Fail_Invalid_Digits_CPF()
        {
            Document document = new Document("11520020073", EDocumentType.CPF);
            Assert.False(document.Valid);
        }

        [Fact]
        public void Should_Success_Valid_CPF()
        {
            Document document = new Document("11520020074", EDocumentType.CPF);
            Assert.True(document.Valid);
        }
    }
}
