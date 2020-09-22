using System;
using NetDevPack.Messaging;

namespace Games.Domain.Events.Person
{
    public class GameLendRemovedEvent : Event
    {
        public GameLendRemovedEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; set; }
    }
}
