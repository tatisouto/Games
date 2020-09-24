using Games.Domain.Commands.Validations.Person;
using System;


namespace Games.Domain.Commands.Person
{
    public class UpdatePersonCommand : PersonCommand
    {

        public UpdatePersonCommand(Guid id, string name, string phone, string email, DateTime created, DateTime? updated)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
            Created = created;
            Updated = updated;
        }

        public override bool IsValid()
        {
            ValidationResult = new UpdatePersonCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}



