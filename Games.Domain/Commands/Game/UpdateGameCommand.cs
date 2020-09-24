using Games.Domain.Commands.Game;
using Games.Domain.Commands.Validations.Game;
using System;

namespace Games.Domain.Commands
{
    public class UpdateGameCommand : GameCommand
    {
        public UpdateGameCommand(Guid id, string description, bool active, DateTime created, DateTime? updated)
        {
            Id = id;
            Description = description;
            Active = active;
            Created = created;
            Updated = updated;
        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateGameCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}



