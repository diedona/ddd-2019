using DDona.DDD.PaymentContext.Domain.Commands;
using DDona.DDD.PaymentContext.Domain.Entities;
using DDona.DDD.PaymentContext.Domain.Repositories;
using DDona.DDD.PaymentContext.Domain.ValueObjects;
using DDona.DDD.PaymentContext.Shared.Commands;
using DDona.DDD.PaymentContext.Shared.Handlers;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Domain.Handler
{
    public class StudentHandler : Notifiable, IHandler<CreateStudentCommand>
    {
        private readonly IStudentRepository _studentRepository;

        public StudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public ICommandResult Handle(CreateStudentCommand command)
        {
            // FAIL FAST VALIDATION
            if(!command.Validate())
            {
                AddNotifications(command);
                return new CommandResult(false, "Invalid data");
            }

            // VO'S
            Name name = new Name(command.FirstName, command.LastName);
            Document doc = new Document(command.DocumentNumber, command.DocumentType);
            Email email = new Email(command.EmailAddress);

            // VALIDATING VO'S GENERAL RULES
            AddNotifications(name, doc, email);
            if(this.Invalid)
            {
                return new CommandResult(false, "Invalid data");
            }

            // VALIDATIONS AT DATABASE, IF ANY...

            // ENTITIES
            Student student = new Student(name, doc, email);

            // SAVE DATA TO DB
            _studentRepository.Save(student);

            // FULL OK
            return new CommandResult(true, "Student created with success");
        }
    }
}
