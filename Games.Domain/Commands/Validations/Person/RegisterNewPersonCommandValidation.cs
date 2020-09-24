using Games.Domain.Commands.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Domain.Commands.Validations.Person
{
    public class RegisterNewPersonCommandValidation : PersonValidation<RegisterNewPersonCommand>
    {

        public RegisterNewPersonCommandValidation()
        {
            ValidateName();            
            ValidateEmail();
            ValidatePhone();
        }
    }
}
