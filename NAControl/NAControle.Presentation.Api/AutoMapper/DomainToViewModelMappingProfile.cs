using AutoMapper;
using NAControle.Domain.Commands.Grupo;
using NAControle.Domain.Models;
using NAControle.Presentation.Api.ViewModel;

namespace NAControle.Presentation.Api.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Grupo, GrupoViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();

            CreateMap<GrupoViewModel, GrupoCommand>();
        }
    }
}