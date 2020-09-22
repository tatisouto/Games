using System;
using NetDevPack.Messaging;

namespace Games.Domain.Events.Person
{
    public class GameRegisteredEvent : Event
    {
        public GameRegisteredEvent(string description, bool active, DateTime created, DateTime? updated)
        {
            Description = description;
            Active = active;
            Created = created;
            Updated = updated;
        }

        public string Description { get; private set; }
        public bool Active { get; private set; }       
        public DateTime Created { get; private set; }

        public DateTime? Updated { get; private set; }
    }
}



