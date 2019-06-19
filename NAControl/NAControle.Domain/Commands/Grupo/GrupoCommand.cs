using NAControle.Domain.Core.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace NAControle.Domain.Commands.Grupo
{
    public abstract class GrupoCommand : Command
    {
        public string Nome { get; set; }
    }
}
