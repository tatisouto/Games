using Games.Domain.Commands.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Domain.Commands.Validations.Game
{
    public class RegisterNewGameCommandValidation : GameValidation<RegisterNewGameCommand>
    {
        public RegisterNewGameCommandValidation()
        {
            ValidateId();
            ValidateDescription();
        }
    }
}
