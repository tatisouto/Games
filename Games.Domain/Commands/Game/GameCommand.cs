using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Domain.Commands.Game
{
    public abstract class GameCommand : Command
    {
        public Guid Id { get; protected set; }
        public string Description { get; protected set; }
        public bool Active { get; protected set; }
        public DateTime Created { get; protected set; }
        public DateTime? Updated { get; protected set; }
    }
}