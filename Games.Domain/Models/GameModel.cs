using NetDevPack.Domain;
using System;
using System.Collections.Generic;

namespace Games.Domain.Models
{
    public class GameModel : Entity, IAggregateRoot
    {
        public GameModel(Guid id, string description, bool active, DateTime created, DateTime? updated)
        {
            Id = id;
            Description = description;
            Active = active;
            Created = created;
            Updated = updated;
        }

        protected GameModel()  {  }
       
        public string Description { get; private set; }
        public bool Active { get; private set; }
        public DateTime Created { get; private set; }
        public DateTime? Updated { get; private set; }

        public virtual IEnumerable<GameLendModel> GameLend { get; private set; }
    }
}


