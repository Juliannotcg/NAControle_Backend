using System;
using System.Collections.Generic;
using System.Text;

namespace NAControle.Domain.Commands.Grupo
{
    public class RegisterNewGrupoCommand : GrupoCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new RegisterNewGrupoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
