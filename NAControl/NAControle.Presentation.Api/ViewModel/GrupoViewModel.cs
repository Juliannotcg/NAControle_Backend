using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NAControle.Presentation.Api.ViewModel
{
    public class GrupoViewModel
    {
        public GrupoViewModel()
        {
            Id = Guid.NewGuid();
            ReuniaoViewModel = new List<ReuniaoViewModel>();
            ServidorViewModel = new List<ServidorViewModel>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Nome do grupo é requerido")]
        [MinLength(2, ErrorMessage = "O tamanho minimo do nome do grupo é {1}")]
        [MaxLength(150, ErrorMessage = "O tamanho máximo do Nome do grupo é {1}")]
        [Display(Name = "Nome do Grupo")]
        public string Nome { get; set; }

        public EnderecoViewModel EnderecoViewModel { get; set; }
        public List<ReuniaoViewModel> ReuniaoViewModel { get; set; }
        public List<ServidorViewModel> ServidorViewModel { get; set; }
    }
}
