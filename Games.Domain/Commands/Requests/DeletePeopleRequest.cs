using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Domain.Commands.Requests
{
    public class DeletePeopleRequest
    {
        public DeletePeopleRequest() { }

        public DeletePeopleRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
