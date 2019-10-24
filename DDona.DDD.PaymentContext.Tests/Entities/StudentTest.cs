using DDona.DDD.PaymentContext.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Tests.Entities
{
    public class StudentTest
    {
        public void TestStudent()
        {
            var student = new Student("Diego", "Doná", "123123123", "diedona@gmail.com");
        }
    }
}
