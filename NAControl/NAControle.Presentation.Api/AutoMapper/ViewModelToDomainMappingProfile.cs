using AutoMapper;
using NAControle.Domain.Commands.Endereco;
using NAControle.Domain.Commands.Grupo;
using NAControle.Presentation.Api.ViewModel;

namespace NAControle.Presentation.Api.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<GrupoViewModel, RegisterNewGrupoCommand>()
                .ConstructUsing(c => 
                new RegisterNewGrupoCommand(
                    c.Nome, 
                    new EnderecoCommand(c.EnderecoViewModel.Logradouro, c.EnderecoViewModel.Lote,
                    c.EnderecoViewModel.Rua, c.EnderecoViewModel.Quadra, c.EnderecoViewModel.Cep,
                    c.EnderecoViewModel.Cidade, c.EnderecoViewModel.Uf, c.EnderecoViewModel.Latitude,
                    c.EnderecoViewModel.Longitude)));
        }
    }
}