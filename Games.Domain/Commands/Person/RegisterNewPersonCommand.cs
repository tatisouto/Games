using System;
using Games.Domain.Commands.Validations.Person;

namespace Games.Domain.Commands.Person
{
    public class RegisterNewPersonCommand : PersonCommand
    {

        public RegisterNewPersonCommand(string name, string phone, string email, DateTime created)
        {
            Name = name;
            Phone = phone;
            Email = email;
            Created = created;
        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewPersonCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
