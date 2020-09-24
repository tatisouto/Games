using System;
using NetDevPack.Messaging;

namespace Games.Domain.Events.Person
{
    public class PersonRemovedEvent : Event
    {
        public PersonRemovedEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; set; }
    }
}
