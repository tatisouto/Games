using NetDevPack.Domain;
using System;
using System.Collections.Generic;

namespace Games.Domain.Models
{
    public class GameLendModel : Entity, IAggregateRoot
    {
        public GameLendModel(Guid id, Guid idPerson, Guid idGame,  DateTime lendOn, DateTime? returnedOn, DateTime created, DateTime? updated)
        {
            Id = id;
            IdPerson = idPerson;
            IdGame = idGame;
            LendOn = lendOn;
            ReturnedOn = returnedOn;
            Created = created;
            Updated = updated;
        }

        public GameLendModel()
        {

        }
      
        public Guid IdPerson { get; private set; }
        public Guid IdGame { get; private set; }
        public DateTime LendOn { get; private set; }
        public DateTime? ReturnedOn { get; private set; }
        public DateTime Created { get; private set; }
        public DateTime? Updated { get; private set; }

        public virtual PersonModel Persons { get; private set; }
        public virtual GameModel Games { get; private set; }
       
    }
}
