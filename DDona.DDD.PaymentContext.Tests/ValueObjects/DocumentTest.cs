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
        [Theory]
        [InlineData("123")]
        [InlineData("123111111111111111111111")]
        [InlineData("12222222222222222222222223")]
        [InlineData("12333333")]
        [InlineData("11520020073")]
        public void Should_Fail_Invalid_CPF(string cpf)
        {
            Document document = new Document(cpf, EDocumentType.CPF);
            Assert.False(document.Valid);
        }

        [Theory]
        [InlineData("77198440096")]
        [InlineData("33686373041")]
        [InlineData("43889411070")]
        public void Should_Success_Valid_CPF(string cpf)
        {
            Document document = new Document(cpf, EDocumentType.CPF);
            Assert.True(document.Valid);
        }

        [Theory]
        [InlineData("123")]
        [InlineData("123111111111111111111111")]
        [InlineData("12222222222222222222222223")]
        [InlineData("12333333")]
        [InlineData("40124269000108")]
        public void Should_Fail_Invalid_CNPJ(string cnpj)
        {
            Document document = new Document(cnpj, EDocumentType.CNPJ);
            Assert.False(document.Valid);
        }

        [Theory]
        [InlineData("40124269000102")]
        [InlineData("83087091000171")]
        [InlineData("19859091000143")]
        public void Should_Success_Valid_CNPJ(string cnpj)
        {
            Document document = new Document(cnpj, EDocumentType.CNPJ);
            Assert.True(document.Valid);
        }
    }
}
