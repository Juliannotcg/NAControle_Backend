using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NAControle.Domain.Commands.Grupo;
using NAControle.Domain.Interfaces;
using NAControle.Presentation.Api.ViewModel;

namespace NAControle.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoController : ControllerBase
    {
        private readonly IGrupoRepository _grupoRepository;
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediator;

        public GrupoController(
            IGrupoRepository grupoRepository,
            IMapper mapper,
            IMediatorHandler mediator)
        {
            _grupoRepository = grupoRepository;
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet]
        [Route("grupos")]
        public IEnumerable<GrupoViewModel> Get()
        {
            return _mapper.Map<IEnumerable<GrupoViewModel>>(_grupoRepository.GetAll());
        }

        [HttpGet]
        [Route("grupo/{id:guid}")]
        public GrupoViewModel Get(Guid id)
        {
            return _mapper.Map<GrupoViewModel>(_grupoRepository.GetById(id));
        }


        [HttpPost]
        [Route("grupos")]
        public IActionResult Post([FromBody]GrupoViewModel grupoViewModel)
        {
            var grupoCommand = _mapper.Map<RegisterNewGrupoCommand>(grupoViewModel);

            _mediator.SendCommand(grupoCommand);
            return Ok();
        }

    }
}
