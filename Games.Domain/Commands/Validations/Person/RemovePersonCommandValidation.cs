using Games.Domain.Commands.Person;

namespace Games.Domain.Commands.Validations.Person
{
    public class RemovePersonCommandValidation : PersonValidation<RemovePersonCommand>
    {
        public RemovePersonCommandValidation()
        {
            ValidateId();
        }
    }
}
