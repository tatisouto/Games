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
            // Send some notification e-mail

            return Task.CompletedTask;
        }

        public Task Handle(GameRegisteredEvent message, CancellationToken cancellationToken)
        {
            // Send some greetings e-mail

            return Task.CompletedTask;
        }

        public Task Handle(GameRemovedEvent message, CancellationToken cancellationToken)
        {
            // Send some see you soon e-mail

            return Task.CompletedTask;
        }

    }
}
