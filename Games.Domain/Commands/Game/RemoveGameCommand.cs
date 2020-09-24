using Games.Domain.Commands.Validations;
using Games.Domain.Commands.Validations.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Domain.Commands.Game
{
    public class RemoveGameCommand : GameCommand
    {
        public RemoveGameCommand(Guid id)
        {
            Id = id;
            AggregateId = id;
        }


        public override bool IsValid()
        {
            ValidationResult = new RemoveGameCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}


