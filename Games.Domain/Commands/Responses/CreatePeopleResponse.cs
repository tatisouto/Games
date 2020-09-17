using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Domain.Commands.Responses
{
   public class CreatePeopleResponse
    {
        public Guid Id { get;  set; }
        public string Name { get;  set; }
        public string Phone { get;  set; }
    }
}
