using NAControle.Domain.Core.Models;
using System;

namespace NAControle.Domain.Models
{
    public class Reuniao : ModelBase
    {
        public Reuniao(DateTime dia,
            DateTime horaInicio, 
            DateTime horaFim, 
            bool aberta, 
            bool ativa,
            Servidor secretario)
        {
            Dia = dia;
            HoraInicio = horaInicio;
            HoraFim = horaFim;
            Aberta = aberta;
            Ativa = ativa;
            Secretario = secretario;
        }

        public Reuniao()
        {
        }
        public DateTime Dia { get; private set; }

        //Validar como o Entity vai tratar TimeSpan
        public DateTime HoraInicio { get; private set; }
        public DateTime HoraFim { get; private set; }
        public bool Aberta { get; private set; }
        public bool Ativa { get; private set; }
        public Servidor Secretario { get; private set; }
    }
}
