using Games.Domain.Commands.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading;

namespace Games.Domain.Commands.Requests
{
    public class UpdatePeopleRequest : ICommand
    {
        public UpdatePeopleRequest() { }

        public UpdatePeopleRequest(Guid id, string name, string phone, DateTime created)
        {
            id = Id;
            Name = name;
            Phone = phone;
            Created = created;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime Created { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}
