using FluentValidation.Results;
using NAControle.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace NAControle.Domain.Core.Command
{
    public abstract class Command : Message
    {
        public ValidationResult ValidationResult { get; set; }

        public abstract bool IsValid();
    }
  
}
