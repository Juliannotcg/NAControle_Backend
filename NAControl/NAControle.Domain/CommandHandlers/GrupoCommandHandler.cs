using MediatR;
using NAControle.Domain.Commands.Grupo;
using NAControle.Domain.Handlers;
using NAControle.Domain.Interfaces;
using NAControle.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace NAControle.Domain.CommandHandlers
{
    public class GrupoCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewGrupoCommand>,
        IRequestHandler<UpdateGrupoCommand>,
        IRequestHandler<RemoveGrupoCommand>
    {
        private readonly IMediatorHandler _mediator;
        private readonly IGrupoRepository _grupoRepository;

        public GrupoCommandHandler(
         IUnitOfWork uow,
         IGrupoRepository grupoRepository,
         IMediatorHandler mediator) : base(uow)
        {
            _grupoRepository = grupoRepository;
            _mediator = mediator;
        }

        public Task Handle(RegisterNewGrupoCommand request, CancellationToken cancellationToken)
        {
            var endereco = new Endereco(request.Endereco.Logradouro, request.Endereco.Lote, request.Endereco.Rua,
                request.Endereco.Quadra, request.Endereco.Cep, request.Endereco.Cidade, request.Endereco.Uf,
                request.Endereco.Latitude, request.Endereco.Longitude);

            var grupo = new Grupo(request.Nome, endereco);

            _grupoRepository.Add(grupo);

            if (Commit())
            {
            }

            return Task.CompletedTask;
        }

        public Task Handle(UpdateGrupoCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task Handle(RemoveGrupoCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
