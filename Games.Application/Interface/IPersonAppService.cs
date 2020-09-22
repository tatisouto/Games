using FluentValidation.Results;
using Games.Application.ViewModels;
using Games.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Games.Application.Interfaces
{
    public interface IPersonAppService :  IDisposable
    {
        Task<IEnumerable<PersonViewModel>> GetAll();
        Task<PersonViewModel> GetById(Guid id);
        Task<ValidationResult> Register(PersonViewModel objViewModel);
        Task<ValidationResult> Update(PersonViewModel objViewModel);
        Task<ValidationResult> Remove(Guid id);
    }
}
