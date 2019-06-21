using NAControle.Domain.Core.Models;
using System.Collections.Generic;

namespace NAControle.Domain.Models
{
    public class Grupo : ModelBase
    {
        public Grupo(string nome,
            Endereco endereco,
            ICollection<Servidor> servidor,
            ICollection<Reuniao> reuniao)
        {
            Nome = nome;
            Endereco = endereco;
            Servidor = servidor;
            Reuniao = reuniao;
        }

        public Grupo()
        {
        }
        public string Nome { get; private set; }
        public Endereco Endereco { get; private set; }
        public ICollection<Servidor> Servidor { get; private set; }
        public ICollection<Reuniao> Reuniao { get; private set; }
    }
}
