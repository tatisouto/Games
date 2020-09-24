using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Domain.Commands.Validations.Game
{
    public class UpdateGameCommandValidation : GameValidation<UpdateGameCommand>
    {
        public UpdateGameCommandValidation()
        {
            ValidateId();
            ValidateDescription();            
        }
    }
}