using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Games.Domain.Events.Person
{
    public class GameEventHandler :
        INotificationHandler<GameRegisteredEvent>,
        INotificationHandler<GameUpdatedEvent>,
        INotificationHandler<GameRemovedEvent>
    {
        public Task Handle(GameUpdatedEvent message, CancellationToken cancellationToken)
        {
           
            return Task.CompletedTask;
        }

        public Task Handle(GameRegisteredEvent message, CancellationToken cancellationToken)
        {
           

            return Task.CompletedTask;
        }

        public Task Handle(GameRemovedEvent message, CancellationToken cancellationToken)
        {
            
            return Task.CompletedTask;
        }

    }
}
