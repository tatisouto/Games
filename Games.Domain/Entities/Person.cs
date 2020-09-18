using System;
using System.Collections.Generic;

namespace Games.Domain.Entities
{
    public class Person : Entity
    {
        public readonly object Games;

        public string Name { get; private set; }
        public string Phone { get; private set; }
        public DateTime Created { get; private set; }
        public DateTime Updated { get; private set; }


       

    }
}

