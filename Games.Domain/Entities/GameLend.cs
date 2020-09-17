using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Domain.Entities
{
    public class GameLend : Entity
    {
        public int IdPeople { get; private set; }
        public int IdGame { get; private set; }      
        public DateTime LendOn { get; private set; }
        public DateTime ReturnedOn { get; private set; }
        public DateTime Created { get; private set; }



    }
}
