using FluentAssertions;
using JonClayton.Packages.HelloWorld;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JonClayton.Packages.Tests.HelloWorld
{
    [TestClass]
    public class CommunicationTests
    {
        [TestMethod]
        public void GreetingsWorks()
        {
            Communication.Greet("Earthling").Should().Be("Greetings Earthling");
        }
    }
}