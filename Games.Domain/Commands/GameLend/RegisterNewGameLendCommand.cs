using Games.Domain.Commands.Game;
using Games.Domain.Commands.Validations.GameLend;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Domain.Commands.GameLend
{
    public class RegisterNewGameLendCommand : GameLendCommand
    {
        public RegisterNewGameLendCommand(Guid idPerson, Guid idGame, DateTime lendOn, DateTime? returnedOn, DateTime created, DateTime? updated)
        {
            IdPerson = idPerson;
            IdGame = idGame;
            LendOn = lendOn;
            ReturnedOn = returnedOn;
            Created = created;
            Updated = updated;
        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewGameLendCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}





