using FluentValidation;
using Games.Domain.Commands.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Domain.Commands.Validations.Person
{
    public abstract class PersonValidation<T> : AbstractValidator<T> where T : PersonCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Please ensure you have entered the Name")
                .Length(2, 150).WithMessage("The Name must have between 2 and 150 characters");
        }

        protected void ValidatePhone()
        {
            RuleFor(c => c.Phone)                
                .NotEmpty().WithMessage("Please ensure you have entered the Phone")
                .Length(11).WithMessage("The Phone must have 11 characters");
        }

        protected void ValidateEmail()
        {
            RuleFor(c => c.Email)
                .NotEmpty()
                .EmailAddress();
        }

        protected void ValidateId()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty);
        }

     
    }
}
