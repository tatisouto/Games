using Games.Domain.Commands.Validations.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Domain.Commands.Game
{
    public class RegisterNewGameCommand : GameCommand
    {

        public RegisterNewGameCommand(string description, bool active, DateTime created, DateTime? updated)
        {
            Description = description;
            Active = active;
            Created = created;
            Updated = updated;
        }



        public override bool IsValid()
        {
            ValidationResult = new RegisterNewGameCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
