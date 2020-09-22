﻿using System.Threading;
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
            // Send some notification e-mail

            return Task.CompletedTask;
        }

        public Task Handle(GameLendRegisteredEvent message, CancellationToken cancellationToken)
        {
            // Send some greetings e-mail

            return Task.CompletedTask;
        }

        public Task Handle(GameLendRemovedEvent message, CancellationToken cancellationToken)
        {
            // Send some see you soon e-mail

            return Task.CompletedTask;
        }

    }
}
