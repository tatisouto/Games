using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Domain.Commands.Person
{
    public abstract class PersonCommand : Command
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string Phone { get; protected set; }
        public string Email { get; protected set; }
        public DateTime Created { get; protected set; }
        public DateTime? Updated { get; protected set; }
    }
}