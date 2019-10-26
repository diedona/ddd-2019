using DDona.DDD.PaymentContext.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Repositories
{
    public interface IStudentRepository
    {
        void Save(Student student);
    }
}
