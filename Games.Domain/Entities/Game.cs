using NetDevPack.Domain;
using System;

namespace Games.Domain.Entities
{
    public class Game : Entity, IAggregateRoot
    {
        public Game(string description, bool active, DateTime created, DateTime? updated)
        {
            Description = description;
            Active = active;
            Created = created;
            Updated = updated;
        }

        protected Game()
        {

        }



        public string Description { get; private set; }
        public bool Active { get; private set; }
        public DateTime Created { get; private set; }
        public DateTime? Updated { get; private set; }
    }
}


