using Games.Domain.Commands.GameLend;
using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace Games.Domain.Commands.Validations.GameLend
{
    public abstract class GameLendValidation<T> : AbstractValidator<T> where T : GameLendCommand
    {
        protected void ValidateLend()
        {
            RuleFor(c => c.LendOn)
                .NotEmpty();
        }

        protected void ValidateId()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty);
        }
    }
}



