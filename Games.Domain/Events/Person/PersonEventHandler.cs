using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Games.Domain.Events.Person
{
    public class PersonEventHandler :
        INotificationHandler<PersonRegisteredEvent>,
        INotificationHandler<PersonUpdatedEvent>,
        INotificationHandler<PersonRemovedEvent>
    {
        public Task Handle(PersonUpdatedEvent message, CancellationToken cancellationToken)
        {
            // Send some notification e-mail

            return Task.CompletedTask;
        }

        public Task Handle(PersonRegisteredEvent message, CancellationToken cancellationToken)
        {
            // Send some greetings e-mail

            return Task.CompletedTask;
        }

        public Task Handle(PersonRemovedEvent message, CancellationToken cancellationToken)
        {
            // Send some see you soon e-mail

            return Task.CompletedTask;
        }

    }
}
