using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NAControle.Presentation.Api.ViewModel
{
    public class ReuniaoViewModel
    {
        public ReuniaoViewModel()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public DateTime Dia { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
        public bool Aberta { get; set; }
        public bool Ativa { get; set; }
        public ServidorViewModel Secretario { get; set; }
    }
}
