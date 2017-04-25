using FinBot.Engine;
using FluentAssertions;
using NUnit.Framework;

namespace FinBot.Tests.Engine
{
    [TestFixture]
    public class BotResponseGeneratorIntegrationTests
    {
        [Test]
        public void GetBotResponse_Hello()
        {
            var bootstrapper = new Bootstrapper();
            var botResponseGenerator = bootstrapper.Get<IBotResponseGenerator>();
            var botResponse = botResponseGenerator.GetBotResponse("hello");

            botResponse.ResponseText.Should().Be("Hello! What's your name?");
        }

        [Test]
        public void GetBotResponse_Balance()
        {
            var bootstrapper = new Bootstrapper();
            var botResponseGenerator = bootstrapper.Get<IBotResponseGenerator>();
            var botResponse = botResponseGenerator.GetBotResponse("MY BALANCE");

            botResponse.ResponseText.Should().Be("Please tell me your bank account number");
        }
    }
}