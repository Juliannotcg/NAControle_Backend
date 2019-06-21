using MediatR;
using NAControle.Domain.Commands.Grupo;
using System.Threading;
using System.Threading.Tasks;

namespace NAControle.Domain.CommandHandlers
{
    public class GrupoCommandHandler :
        IRequestHandler<RegisterNewGrupoCommand, bool>,
        IRequestHandler<UpdateGrupoCommand, bool>,
        IRequestHandler<RemoveGrupoCommand, bool>
    {
        public Task<bool> Handle(RegisterNewGrupoCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(true);
        }

        public Task<bool> Handle(UpdateGrupoCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(true);
        }

        public Task<bool> Handle(RemoveGrupoCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(true);
        }
    }
}
