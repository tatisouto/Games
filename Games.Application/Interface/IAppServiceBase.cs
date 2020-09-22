using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace Games.Application.Interfaces
{
   public  interface IAppServiceBase<TEntity> where TEntity : class
    {

        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(Guid id);

        Task<ValidationResult> Register(TEntity obj);
        Task<ValidationResult> Update(TEntity obj);
        Task<ValidationResult> Remove(Guid id);  
        
    }
}

