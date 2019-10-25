using DDona.DDD.PaymentContext.Domain.Enums;
using DDona.DDD.PaymentContext.Shared.ValueObjects;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;

            AddNotifications(new Contract()
                .Requires().IsTrue(ValidateNumber(), "Document.Number", "Invalid document number!")
            );
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }

        private bool ValidateNumber()
        {
            // TO-DO:   REAL VALIDATION
            //          REMOVE IF?

            if(Type == EDocumentType.CNPJ && Number.Length == 14)
            {
                return true;
            }

            if (Type == EDocumentType.CPF && Number.Length == 11)
            {
                return true;
            }

            return false;
        }
    }
}
