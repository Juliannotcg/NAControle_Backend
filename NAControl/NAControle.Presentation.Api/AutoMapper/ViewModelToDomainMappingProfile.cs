using AutoMapper;
using NAControle.Domain.Commands.Grupo;
using NAControle.Presentation.Api.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NAControle.Presentation.Api.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<GrupoViewModel, RegisterNewGrupoCommand>()
                .ConstructUsing(c => new RegisterNewGrupoCommand());

        }
    }
}