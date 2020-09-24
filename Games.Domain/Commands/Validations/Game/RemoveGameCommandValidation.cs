using Games.Domain.Commands.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Domain.Commands.Validations.Game
{
    public class RemoveGameCommandValidation : GameValidation<RemoveGameCommand>
    {
        public RemoveGameCommandValidation()
        {
            ValidateId();
        }
    }
}

