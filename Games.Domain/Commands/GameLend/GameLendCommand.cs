using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Domain.Commands.GameLend
{
    public abstract class GameLendCommand : Command
    {
        public Guid Id { get; protected set; }
        public Guid IdPerson { get; protected set; }
        public Guid IdGame { get; protected set; }
        public DateTime LendOn { get; protected set; }
        public DateTime? ReturnedOn { get; protected set; }
        public DateTime Created { get; protected set; }
        public DateTime? Updated { get; protected set; }
      
    }
}
