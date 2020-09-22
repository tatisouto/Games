using FluentValidation.Results;
using Games.Application.EventSourcedNormalizers;
using Games.Application.ViewModels;
using Games.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Games.Application.Interfaces
{
   public interface IGameAppService: IDisposable
    {
        Task<IEnumerable<GameViewModel>> GetAll();
        Task<GameViewModel> GetById(Guid id);
        Task<ValidationResult> Register(GameViewModel objViewModel);
        Task<ValidationResult> Update(GameViewModel objViewModel);
        Task<ValidationResult> Remove(Guid id);
        Task<IList<PersonHistoryData>> GetAllHistory(Guid id);
    }
}
