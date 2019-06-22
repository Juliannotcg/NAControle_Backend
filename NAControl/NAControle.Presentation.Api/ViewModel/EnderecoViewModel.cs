using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NAControle.Presentation.Api.ViewModel
{
    public class EnderecoViewModel
    {
        public string Logradouro { get; set; }
        public int Lote { get; set; }
        public int Rua { get; set; }
        public int Quadra { get; set; }
        public int Cep { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
