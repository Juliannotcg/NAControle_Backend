using NAControle.Domain.Commands.Endereco;
using NAControle.Domain.Validations.Grupo;
using System.Collections.Generic;

namespace NAControle.Domain.Commands.Grupo
{
    public class RegisterNewGrupoCommand : GrupoCommand
    {
        public RegisterNewGrupoCommand(
            string nome,
            EnderecoCommand endereco)
        {
            Endereco = endereco;
            Nome = nome;
        }

        public EnderecoCommand Endereco { get; set; }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewGrupoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
