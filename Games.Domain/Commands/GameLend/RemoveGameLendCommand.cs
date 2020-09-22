using Games.Domain.Commands.Validations.GameLend;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Domain.Commands.GameLend
{
    public class RemoveGameLendCommand : GameLendCommand
    {
        public RemoveGameLendCommand(Guid id)
        {
            Id = id;
            AggregateId = id;
        }


        public override bool IsValid()
        {
            ValidationResult = new RemoveGameLendCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
