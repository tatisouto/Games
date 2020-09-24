using FluentValidation;
using Games.Domain.Commands.Game;
using System;

namespace Games.Domain.Commands.Validations.Game
{
    public abstract class GameValidation <T> : AbstractValidator<T> where T : GameCommand
    {
        protected void ValidateDescription()
        {
            RuleFor(c => c.Description)
                .NotEmpty().WithMessage("Please ensure you have entered the Description")
                .Length(2, 150).WithMessage("The Name must have between 2 and 150 characters");
        }      

        protected void ValidateId()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty);
        }
    }
}

