using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;

namespace Games.Domain.Entities
{
    public class People : Entity    {
      
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public DateTime Created { get; private set; }
    }
}

