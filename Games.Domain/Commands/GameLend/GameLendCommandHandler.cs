using Games.Domain.Interfaces.Repositories;
using MediatR;
using NetDevPack.Messaging;
using System;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation.Results;


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

        public Task<ValidationResult> Handle(RegisterNewGameLendCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ValidationResult> Handle(UpdateGameLendCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ValidationResult> Handle(RemoveGameLendCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
