using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NAControle.Presentation.Api.ViewModel
{
    public class ServidorViewModel
    {
        public ServidorViewModel()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Descricao { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public EnderecoViewModel EnderecoViewModel { get; set; }
    }
}
