using System;
using NetDevPack.Messaging;

namespace Games.Domain.Events.Person
{
    public class GameRemovedEvent : Event
    {
        public GameRemovedEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; set; }
    }
}
