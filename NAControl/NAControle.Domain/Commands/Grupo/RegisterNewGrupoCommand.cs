using NAControle.Domain.Validations.Grupo;
using System;
using System.Collections.Generic;
using System.Text;

namespace NAControle.Domain.Commands.Grupo
{
    public class RegisterNewGrupoCommand : GrupoCommand
    {
        public ICollection<Guid> IdServidores { get; set; }
        public Guid IdEndereco { get; set; }


        public override bool IsValid()
        {
            ValidationResult = new RegisterNewGrupoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
