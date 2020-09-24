using System;
using NetDevPack.Messaging;

namespace Games.Domain.Events.Person
{
    public class GameLendRegisteredEvent : Event
    {
        public GameLendRegisteredEvent(Guid idPerson, Guid idGame, DateTime lendOn, DateTime? returnedOn, DateTime created, DateTime? updated)
        {
            IdPerson = idPerson;
            IdGame = idGame;
            LendOn = lendOn;
            ReturnedOn = returnedOn;
            Created = created;
            Updated = updated;
        }

        public Guid IdPerson { get; private set; }
        public Guid IdGame { get; private set; }
        public DateTime LendOn { get; private set; }
        public DateTime? ReturnedOn { get; private set; }       
        public DateTime Created { get; private set; }

        public DateTime? Updated { get; private set; }
    }
}



