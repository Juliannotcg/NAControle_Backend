using MediatR;
using NAControle.Domain.Commands.Grupo;
using NAControle.Domain.Handlers;
using NAControle.Domain.Interfaces;
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
            _mediator.SendCommand(request);

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
