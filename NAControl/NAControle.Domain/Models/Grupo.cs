using NAControle.Domain.Core.Models;
using System.Collections.Generic;

namespace NAControle.Domain.Models
{
    public class Grupo : ModelBase
    {
        public Grupo(string nome,
            Endereco endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }

        public Grupo()
        {
        }
        public string Nome { get; private set; }
        public Endereco Endereco { get; private set; }
    }
}
