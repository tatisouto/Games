using Games.Domain.Commands.Validations.GameLend;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Domain.Commands.GameLend
{
    public class UpdateGameLendCommand : GameLendCommand
    {
        public UpdateGameLendCommand(Guid id, Guid idPerson, Guid idGame, DateTime lendOn, DateTime? returnedOn, DateTime created, DateTime? updated)
        {
            Id = id;
            IdGame = idGame;
            LendOn = lendOn;
            ReturnedOn = returnedOn;
            Created = created;
            Updated = updated;
        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateGameLendCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
