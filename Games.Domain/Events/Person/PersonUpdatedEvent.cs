using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Domain.Events.Person
{
    public class PersonUpdatedEvent : Event
    {
        public PersonUpdatedEvent(string name, string phone, string email, DateTime created, DateTime? updated)
        {
            Name = name;
            Phone = phone;
            Email = email;
            Created = created;
            Updated = updated;
        }

        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public DateTime Created { get; private set; }
        public DateTime? Updated { get; private set; }

    }
}
