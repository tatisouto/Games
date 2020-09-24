using Games.Domain.Commands.Person;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Games.Tests.CommandTests
{
    [TestClass]
    public class CreatePersonCommandTests
    {
        private readonly RegisterNewPersonCommand _validCreatePerson = new RegisterNewPersonCommand("Maria da Silva!", "991913376", "tatisouto@gmail.com", DateTime.Today);
        private readonly RegisterNewPersonCommand _InvalidCreatePerson = new RegisterNewPersonCommand("", "9999990090999", "maria@uol.com.br", DateTime.Today);

        public CreatePersonCommandTests()
        {
            _validCreatePerson.IsValid();
            _InvalidCreatePerson.IsValid();
        }

        [TestMethod]
        public void DataCommandInvalid()
        {
            Assert.AreEqual(_InvalidCreatePerson.IsValid(), false);
        }

        [TestMethod]
        public void DataCommandValid()
        {
            Assert.AreEqual(_validCreatePerson.IsValid(), true);
        }

        
    }
}
