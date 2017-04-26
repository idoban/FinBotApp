using FinBot.Engine;
using FluentAssertions;
using NUnit.Framework;

namespace FinBot.Tests.Engine
{
    [TestFixture]
    public class BotResponseGeneratorTests
    {
        [Test]
        public void GetBotResponse_Hello()
        {
            var botResponseGenerator = InitializeBotResponseGenerator();
            var botResponse = botResponseGenerator.GetBotResponse("hello");

            botResponse.ResponseText.Should().Be("Hello! What's your name?");
        }

        [Test]
        public void GetBotResponse_Balance()
        {
            var botResponseGenerator = InitializeBotResponseGenerator();
            var botResponse = botResponseGenerator.GetBotResponse("MY BALANCE");

            botResponse.ResponseText.Should().Be("Please tell me your bank account number");
        }

        [Test]
        public void GetBotResponse_IntroductionConversation_BotShouldRemember()
        {
            var botResponseGenerator = InitializeBotResponseGenerator();

            AssertResponse(botResponseGenerator, "Hi", "Hello! What's your name?");
            AssertResponse(botResponseGenerator, "My name is Chuck", "Alright I will remember your name Chuck");
            AssertResponse(botResponseGenerator, "What is my name?", "Your name is Chuck");
        }

        private static void AssertResponse(IBotResponseGenerator botResponseGenerator, string input, string response)
        {
            var botResponse = botResponseGenerator.GetBotResponse(input);
            botResponse.ResponseText.Should().Be(response);
        }

        private static IBotResponseGenerator InitializeBotResponseGenerator()
        {
            var bootstrapper = new Bootstrapper();
            var botResponseGenerator = bootstrapper.Get<IBotResponseGenerator>();
            return botResponseGenerator;
        }
    }
}