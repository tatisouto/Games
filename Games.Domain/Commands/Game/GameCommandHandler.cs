using Games.Domain.Interfaces.Repositories;
using MediatR;
using NetDevPack.Messaging;
using System;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation.Results;
using Games.Domain.Events;
using Games.Domain.Interfaces;
using Games.Domain.Models;
using Games.Domain.Events.Person;

namespace Games.Domain.Commands.Game
{
    public class GameCommandHandler : CommandHandler, IRequestHandler<RegisterNewGameCommand, ValidationResult>,
        IRequestHandler<UpdateGameCommand, ValidationResult>,
        IRequestHandler<RemoveGameCommand, ValidationResult>
    {
        private readonly IGameRepository _gameRepository;
 
        public GameCommandHandler(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public async Task<ValidationResult> Handle(RegisterNewGameCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var game = new GameModel (Guid.NewGuid(), message.Description, message.Active, message.Created, message.Updated);


            if (await _gameRepository.GetByDescription(game.Description) != null)
            {
                AddError("Game já cadastrado.");
                return ValidationResult;
            }

            game.AddDomainEvent(new GameRegisteredEvent(game.Description, game.Active, game.Created, game.Updated));

            _gameRepository.Add(game);

            return await Commit(_gameRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateGameCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var game = new GameModel(Guid.NewGuid(), message.Description, message.Active, message.Created, message.Updated);


            if (await _gameRepository.GetByDescription(game.Description) != null)
            {
                AddError("Game já cadastrado.");
                return ValidationResult;
            }

            game.AddDomainEvent(new GameRegisteredEvent(game.Description, game.Active, game.Created, game.Updated));

            _gameRepository.Update(game);

            return await Commit(_gameRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(RemoveGameCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var game = await _gameRepository.GetById(message.Id);

            if (game is null)
            {
                AddError("Game não existe.");
                return ValidationResult;
            }

            game.AddDomainEvent(new GameRemovedEvent(message.Id));

            _gameRepository.Remove(game);

            return await Commit(_gameRepository.UnitOfWork);
        }
    }
}
