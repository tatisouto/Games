using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Domain.Entities
{
    public class Game : Entity
    {
        public string Description { get; private set; }
        public bool Active { get; private set; }
        public DateTime Created { get; private set; }
    }
}


