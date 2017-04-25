using FinBot.Engine;
using FluentAssertions;
using NUnit.Framework;

namespace FinBot.Tests.Engine
{
    [TestFixture]
    public class BotResponseGeneratorIntegrationTests
    {
        [Test]
        public void GetAll_DoesNotContainContentNodes()
        {
            var bootstrapper = new Bootstrapper();
            var botResponseGenerator = bootstrapper.Get<IBotResponseGenerator>();
            var botResponse = botResponseGenerator.GetBotResponse("hello");

            botResponse.ResponseText.Should().Be("Hello! What's your name?");
        }
    }
}