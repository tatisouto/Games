﻿using NetDevPack.Domain;
using System;
using System.Collections.Generic;

namespace Games.Domain.Entities
{
    public class Person : Entity, IAggregateRoot
    {

        public Person(Guid id, string name, string phone, string email, DateTime created, DateTime? updated)
        {
            Id = id;
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
        public virtual IEnumerable<GameLend> GameLend { get; private set; }


    }
}

