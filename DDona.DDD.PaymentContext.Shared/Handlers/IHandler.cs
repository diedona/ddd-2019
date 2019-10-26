using DDona.DDD.PaymentContext.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ICommand = DDona.DDD.PaymentContext.Shared.Commands.ICommand;

namespace DDona.DDD.PaymentContext.Shared.Handlers
{
    public interface IHandler<T> where T: ICommand
    {
        ICommandResult Handle(T command);
    }
}
