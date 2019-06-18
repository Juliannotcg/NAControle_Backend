using NAControle.Domain.Core.Models;
using System;

namespace NAControle.Domain.Models
{
    public class Reuniao : ModelBase
    {
        public Reuniao(DateTime dia, 
            TimeSpan horaInicio, 
            TimeSpan horaFim, 
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

        public DateTime Dia { get; private set; }
        public TimeSpan HoraInicio { get; private set; }
        public TimeSpan HoraFim { get; private set; }
        public bool Aberta { get; private set; }
        public bool Ativa { get; private set; }
        public Servidor Secretario { get; private set; }
    }
}
