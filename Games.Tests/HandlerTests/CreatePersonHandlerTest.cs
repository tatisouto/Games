using Games.Domain.Commands.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Tests.HandlerTests
{
    public class CreatePersonHandlerTest
    {
        private readonly RegisterNewPersonCommand _validCreatePerson = new RegisterNewPersonCommand("Maria da Silva!", "991913376", "tatisouto@gmail.com", DateTime.Today);
        private readonly RegisterNewPersonCommand _InvalidCreatePerson = new RegisterNewPersonCommand("", "9999990090999", "maria@uol.com.br", DateTime.Today);

        //private PersonCommandHandler _result = new PersonCommandHandler().Handle;

        public CreatePersonHandlerTest()
        {

        }
       
    }
}
