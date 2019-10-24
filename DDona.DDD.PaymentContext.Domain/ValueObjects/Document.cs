using DDona.DDD.PaymentContext.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.ValueObjects
{
    public class Document
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }
    }
}
