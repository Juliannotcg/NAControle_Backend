using NAControle.Domain.Core.Models;

namespace NAControle.Domain.Models
{
    public class Endereco : ModelBase
    {
        public Endereco(string logradouro,
            int lote,
            int rua,
            int quadra,
            int cep,
            string cidade,
            string uf, 
            string latitude, 
            string longitude)
        {
            Logradouro = logradouro;
            Lote = lote;
            Rua = rua;
            Quadra = quadra;
            Cep = cep;
            Cidade = cidade;
            Uf = uf;
            Latitude = latitude;
            Longitude = longitude;
        }

        public string Logradouro { get; private set; }
        public int Lote { get; private set; }
        public int Rua { get; private set; }
        public int Quadra { get; private set; }
        public int Cep { get; private set; }
        public string Cidade { get; private set; }
        public string Uf { get; private set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
