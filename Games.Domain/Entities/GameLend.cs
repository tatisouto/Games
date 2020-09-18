using System;
using System.Collections.Generic;

namespace Games.Domain.Entities
{
    public class GameLend : Entity
    {
        public int IdPerson { get; private set; }
        public int IdGame { get; private set; }      
        public DateTime LendOn { get; private set; }
        public DateTime ReturnedOn { get; private set; }
        public DateTime Created { get; private set; }
        public DateTime Updated { get; private set; }


        public virtual Person Persons { get; private set; }
        public virtual Game Games { get; set; }

    }
}
