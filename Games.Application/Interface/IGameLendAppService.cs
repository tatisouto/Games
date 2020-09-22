using FluentValidation.Results;
using Games.Application.ViewModels;
using Games.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Games.Application.Interfaces
{
    public interface IGameLendAppService : IDisposable
    {
        Task<IEnumerable<GameLendViewModel>> GetAll();
        Task<GameLendViewModel> GetById(Guid id);
        Task<ValidationResult> Register(GameLendViewModel objViewModel);
        Task<ValidationResult> Update(GameLendViewModel objViewModel);
        Task<ValidationResult> Remove(Guid id);
        //Task<IList<PersonHistoryData>> GetAllHistory(Guid id);
    }
}
