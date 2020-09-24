using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Games.Domain.Events.Person
{
    public class GameLendEventHandler :
        INotificationHandler<GameLendRegisteredEvent>,
        INotificationHandler<GameLendUpdatedEvent>,
        INotificationHandler<GameLendRemovedEvent>
    {
        public Task Handle(GameLendUpdatedEvent message, CancellationToken cancellationToken)
        {
            
            return Task.CompletedTask;
        }

        public Task Handle(GameLendRegisteredEvent message, CancellationToken cancellationToken)
        {
            
            return Task.CompletedTask;
        }

        public Task Handle(GameLendRemovedEvent message, CancellationToken cancellationToken)
        {
           

            return Task.CompletedTask;
        }

    }
}
