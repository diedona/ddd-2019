using DDona.DDD.PaymentContext.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DDona.DDD.PaymentContext.Shared.Handlers
{
    public interface IHandler<T> where T: Commands.ICommand
    {
        ICommandResult Handle(T command);
    }
}
