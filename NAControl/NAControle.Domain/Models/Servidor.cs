using NAControle.Domain.Core.Models;

namespace NAControle.Domain.Models
{
    public class Servidor : ModelBase
    {
        public Servidor(string nome, 
            string sobreNome,
            string descricao,
            string telefone, 
            string email, 
            Endereco endereco)
        {
            Nome = nome;
            SobreNome = sobreNome;
            Descricao = descricao;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
        }
        public Servidor()
        {
        }

        public string Nome { get; private set; }
        public string SobreNome { get; private set; }
        public string Descricao { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public Endereco Endereco { get; private set; }
    }
}
