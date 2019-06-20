using System;
using System.Collections.Generic;
using System.Text;

namespace NAControle.Domain.Commands.Grupo
{
    public class RemoveGrupoCommand : GrupoCommand
    {
        public RemoveGrupoCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
