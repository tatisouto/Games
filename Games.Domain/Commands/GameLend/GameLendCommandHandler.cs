using Games.Domain.Interfaces.Repositories;
using MediatR;
using NetDevPack.Messaging;
using System;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation.Results;
using Games.Domain.Events.Person;

namespace Games.Domain.Commands.GameLend
{
    public class GameLendCommandHandler : CommandHandler, IRequestHandler<RegisterNewGameLendCommand, ValidationResult>,
        IRequestHandler<UpdateGameLendCommand, ValidationResult>,
        IRequestHandler<RemoveGameLendCommand, ValidationResult>
    {

        private readonly IGameLendRepository _gameLendRepository;

        public GameLendCommandHandler(IGameLendRepository gameLendRepository)
        {
            _gameLendRepository = gameLendRepository;
        }

        public async Task<ValidationResult> Handle(RegisterNewGameLendCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var gameLend = new GameLend(Guid.NewGuid(), message.IdGame, message.IdPerson, message.LendOn, message.ReturnedOn, message.Created, message.Updated);


            if (await _gameLendRepository.GameIsAvailable(gameLend.IdGame) == false)
            {
                AddError("Game já emprestado.");
                return ValidationResult;
            }

            gameLend.AddDomainEvent(new GameLendRegisteredEvent(gameLend.IdPerson, gameLend.IdGame, gameLend.LendOn, gameLend.ReturnedOn, gameLend.Created, gameLend.Updated));

            _gameLendRepository.Add(gameLend);

            return await Commit(_gameLendRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateGameLendCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var gameLend = new GameLend(Guid.NewGuid(), message.IdGame, message.IdPerson, message.LendOn, message.ReturnedOn, message.Created, message.Updated);


            gameLend.AddDomainEvent(new GameLendRegisteredEvent(gameLend.IdPerson, gameLend.IdGame, gameLend.LendOn, gameLend.ReturnedOn, gameLend.Created, gameLend.Updated));

            _gameLendRepository.Add(gameLend);

            return await Commit(_gameLendRepository.UnitOfWork);
        }

        public Task<ValidationResult> Handle(RemoveGameLendCommand message, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
