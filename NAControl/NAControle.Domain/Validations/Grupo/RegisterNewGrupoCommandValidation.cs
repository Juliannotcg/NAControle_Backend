using NAControle.Domain.Commands.Grupo;
using System;
using System.Collections.Generic;
using System.Text;

namespace NAControle.Domain.Validations.Grupo
{
    public class RegisterNewGrupoCommandValidation : GrupoValidation<RegisterNewGrupoCommand>
    {
        public RegisterNewGrupoCommandValidation()
        {
            ValidateNomeGrupo();
        }
    }
}
