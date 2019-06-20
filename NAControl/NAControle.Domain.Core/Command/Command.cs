using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace NAControle.Domain.Core.Command
{
    public abstract class Command : IRequest<bool>, INotification
    {
        public ValidationResult ValidationResult { get; set; }

        public abstract bool IsValid();
    }
  
}
