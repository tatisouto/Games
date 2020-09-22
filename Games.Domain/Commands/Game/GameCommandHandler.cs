using Games.Domain.Interfaces.Repositories;
using MediatR;
using NetDevPack.Messaging;
using System;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation.Results;



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

        public Task<ValidationResult> Handle(RegisterNewGameCommand message, CancellationToken cancellationToken)
        {

            throw new NotImplementedException();
        }

        public Task<ValidationResult> Handle(UpdateGameCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ValidationResult> Handle(RemoveGameCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
