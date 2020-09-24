using Games.Domain.Commands.Person;

namespace Games.Domain.Commands.Validations.Person
{
    public class UpdatePersonCommandValidation : PersonValidation<UpdatePersonCommand>
    {
        public UpdatePersonCommandValidation()
        {
            ValidateId();
            ValidateName();
            ValidateEmail();
            ValidatePhone();
        }
    }
}
