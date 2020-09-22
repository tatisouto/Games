using System;
using NetDevPack.Messaging;

namespace Games.Domain.Events.Person
{
    public class PersonRegisteredEvent : Event
    {
        public PersonRegisteredEvent(string name, string phone, string email, DateTime created)
        {
            Name = name;
            Phone = phone;
            Email = email;
            Created = created;
           
        }

        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public DateTime Created { get; private set; }       
    }
}
