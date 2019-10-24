using DDona.DDD.PaymentContext.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DDona.DDD.PaymentContext.Tests.Entities
{
    public class TestPayer
    {
        [Fact]
        public void Should_Fail_Fisico_Invalid_Document()
        {
            Assert.Throws<Exception>(() => new PayerFisico("Plinio", "123", "Limeira"));            
        }

        [Fact]
        public void Should_Success_Fisico_Valid_Document()
        {
            Payer payer = new PayerFisico("Plinio", "123456789012", "Limeira");
        }
    }
}
