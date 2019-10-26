using DDona.DDD.PaymentContext.Domain.Enums;
using DDona.DDD.PaymentContext.Shared.Commands;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Commands
{
    public class CreateStudentCommand : Notifiable, ICommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string DocumentNumber { get; set; }
        public EDocumentType DocumentType { get; set; }

        public string EmailAddress { get; set; }

        public bool Validate()
        {
            AddNotifications(new Contract().Requires()
                .IsNotNullOrEmpty(FirstName, "FirstName", "Invalid first name")
                .IsNotNullOrEmpty(FirstName, "FirstName", "Invalid first name")
            );

            return this.Valid;
        }
    }
}
