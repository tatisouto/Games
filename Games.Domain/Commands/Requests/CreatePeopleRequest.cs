using Games.Domain.Commands.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Games.Domain.Commands.Requests
{
    public class CreatePeopleRequest
    {

        public string Name { get;  set; }
        public string Phone { get;  set; }
    }
}
