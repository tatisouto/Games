﻿using Games.Domain.Commands.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading;

namespace Games.Domain.Commands.Requests
{
    public class CreatePeopleRequest : ICommand
    {

        public CreatePeopleRequest() { }

        public CreatePeopleRequest(string name, string phone, DateTime created)
        {
            Name = name;
            Phone = phone;
            Created = created;

        }      

        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime Created { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}
