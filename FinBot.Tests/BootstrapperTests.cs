using FinBot.Engine;
using FluentAssertions;
using NUnit.Framework;

namespace FinBot.Tests
{
    [TestFixture]
    public class BootstrapperTests
    {
        [Test]
        public void Get_ITipsAndTricksRepository_Resolved()
        {
            // Act
            var bootstrapper = new Bootstrapper();
            var botResponseGenerator = bootstrapper.Get<IBotResponseGenerator>();

            // Assert
            botResponseGenerator.Should().BeAssignableTo<IBotResponseGenerator>();
        }
    }
}