using AutoMapper;
using FluentValidation.Results;
using Games.Application.Interfaces;
using Games.Application.ViewModels;
using Games.Domain.Models;
using Games.Domain.Interfaces.Repositories;
using Games.Infra.Data.Repository.EventSourcing;
using NetDevPack.Mediator;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Games.Domain.Commands.GameLend;

namespace Games.Application.Services
{
    public class GameLendAppService : IGameLendAppService
    {
        private readonly IMapper _mapper;
        private readonly IGameLendRepository _gameLendRepository;
        private readonly IEventStoreRepository _eventStoreRepository;
        private readonly IMediatorHandler _mediator;


        public GameLendAppService(IMapper mapper,
                                  IGameLendRepository gameLendRepository,
                                  IMediatorHandler mediator,
                                  IEventStoreRepository eventStoreRepository)
        {
            _mapper = mapper;
            _gameLendRepository = gameLendRepository;
            _mediator = mediator;
            _eventStoreRepository = eventStoreRepository;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task<IEnumerable<GameLendViewModel>> GetAll()
        {
            return _mapper.Map<IEnumerable<GameLendViewModel>>(await _gameLendRepository.GetAll());
        }

        public async Task<GameLendViewModel> GetById(Guid id)
        {
            return _mapper.Map<GameLendViewModel>(await _gameLendRepository.GetById(id));
        }

        public async Task<ValidationResult> Register(GameLendViewModel objViewModel)
        {
            var registerCommand = _mapper.Map<RegisterNewGameLendCommand>(objViewModel);
            return await _mediator.SendCommand(registerCommand);
        }

        public Task<ValidationResult> Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ValidationResult> Update(GameLendViewModel objViewModel)
        {
            var updateCommand = _mapper.Map<UpdateGameLendCommand>(objViewModel);
            return await _mediator.SendCommand(updateCommand);
        }

        public bool GameIsAvailable(Guid idGame) {
            return  _gameLendRepository.GameIsAvailable(idGame);
        }
    }
}
