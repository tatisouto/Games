using NetDevPack.Domain;
using System;
using System.Collections.Generic;

namespace Games.Domain.Entities
{
    public class GameLend : Entity, IAggregateRoot
    {
        public GameLend(Guid id, Guid idPerson, Guid idGame,  DateTime lendOn, DateTime? returnedOn, DateTime created, DateTime? updated)
        {
            Id = id;
            IdPerson = idPerson;
            IdGame = idGame;
            LendOn = lendOn;
            ReturnedOn = returnedOn;
            Created = created;
            Updated = updated;
        }

        public GameLend()
        {

        }
      
        public Guid IdPerson { get; private set; }
        public Guid IdGame { get; private set; }
        public DateTime LendOn { get; private set; }
        public DateTime? ReturnedOn { get; private set; }
        public DateTime Created { get; private set; }
        public DateTime? Updated { get; private set; }

        public virtual Person Persons { get; private set; }
        public virtual Game Games { get; private set; }
       
    }
}
