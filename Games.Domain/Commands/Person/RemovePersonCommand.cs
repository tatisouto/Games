using Games.Domain.Commands.Validations.Person;
using System;

namespace Games.Domain.Commands.Person
{
    public class RemovePersonCommand : PersonCommand
    {
        public RemovePersonCommand(Guid id)
        {
            Id = id;
            AggregateId = id;
        }


        public override bool IsValid()
        {
            ValidationResult = new RemovePersonCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}


