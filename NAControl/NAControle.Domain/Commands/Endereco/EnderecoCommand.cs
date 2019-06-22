using NAControle.Domain.Core.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace NAControle.Domain.Commands.Endereco
{
    public class EnderecoCommand : Command
    {
        public EnderecoCommand(
            string logradouro,
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

        public string Logradouro { get; set; }
        public int Lote { get; set; }
        public int Rua { get; set; }
        public int Quadra { get; set; }
        public int Cep { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
