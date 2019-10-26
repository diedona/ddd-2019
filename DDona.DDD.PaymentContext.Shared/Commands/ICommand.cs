using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DDD.PaymentContext.Shared.Commands
{
    public interface ICommand
    {
        bool Validate();
    }
}
