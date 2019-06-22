using MediatR;
using NAControle.Domain.Core.Command;
using NAControle.Domain.Interfaces;
using System.Threading.Tasks;

namespace NAControle.Domain.Handlers
{
    public class MediatorHandler : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public MediatorHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task SendCommand<T>(T command) where T : Command
        {
           await _mediator.Send(command);
        }
    }
}