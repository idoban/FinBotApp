﻿using System;
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
        public void GetBotResponse_InputContainsInvalidCharacters_CorrectResponse()
        {
            var botResponseGenerator = InitializeBotResponseGenerator();

            AssertResponse(botResponseGenerator, "\u202Bhi", "Hello! What's your name?");
        }

        [Test]
        public void GetBotResponse_IntroductionConversation_BotShouldRemember()
        {
            var botResponseGenerator = InitializeBotResponseGenerator();

            AssertResponse(botResponseGenerator, "Hi", "Hello! What's your name?");
            AssertResponse(botResponseGenerator, "My name is Chuck", "Hello Chuck. It's nice to meet you. My name is Fin your personal finance ninja");
            AssertResponse(botResponseGenerator, "What is my name?", "Your name is Chuck");
        }

        [Test]
        public void GetBotResponse_UpcomingCreditCardChargeAmount()
        {
            var botResponseGenerator = InitializeBotResponseGenerator(new MockFinancialServices());

            AssertResponse(botResponseGenerator, 
                "WHAT IS MY UPCOMING CREDIT CARD CHARGE",
                "Your upcoming credit card charge is 100");
        }
        [Test]
        public void GetBotResponse_Payslip()
        {
            var botResponseGenerator = InitializeBotResponseGenerator(new MockFinancialServices());

            AssertResponse(botResponseGenerator,
                "HAVE I RECEIVED MY PAYSLIP",
                "Yes");
        }
        [Test]
        public void GetBotResponse_Payments()
        {
            var botResponseGenerator = InitializeBotResponseGenerator(new MockFinancialServices());

            AssertResponse(botResponseGenerator,
                "HOW MANY PAYMENTS DO I HAVE TO PAY FOR car",
                "You have 6 remaining payments for car");
        }

        [Test]
        public void GetBotResponse_CategoryBudget_SetAndGet()
        {
            var botResponseGenerator = InitializeBotResponseGenerator(new MockFinancialServices());

            AssertResponse(botResponseGenerator,
                "budget for shoes is 987",
                "I'll remember that.");
            AssertResponse(botResponseGenerator,
                "what is my budget for shoes",
                "Your budget for shoes is 987");
        }

        [Test]
        public void GetBotResponse_UpcomingCreditCardChangeDate()
        {
            var botResponseGenerator = InitializeBotResponseGenerator(
                new MockFinancialServices(), 
                new MockDateTimeProvider(new DateTime(2017, 6, 1)));

            AssertResponse(botResponseGenerator,
                "Hey Fin, could you please remind me when will my credit card be charged?",
                "Sure User, in 9 days days! HANG IN THERE!!!");
        }

        [Test]
        public void GetBotResponse_Balance()
        {
            var botResponseGenerator = InitializeBotResponseGenerator(new MockFinancialServices());

            AssertResponse(botResponseGenerator, "What is my balance", "Your balance is 200");
        }

        [Test]
        public void GetBotResponse_Balance_LongQuestion()
        {
            var botResponseGenerator = InitializeBotResponseGenerator(new MockFinancialServices());

            AssertResponse(botResponseGenerator, 
                "Could you please tell me what my balance is?", 
                "Your balance is 200");
        }

        private static void AssertResponse(IBotResponseGenerator botResponseGenerator, string input, string response)
        {
            var botResponse = botResponseGenerator.GetBotResponse(input);
            botResponse.ResponseText.Should().Be(response);
        }

        private static IBotResponseGenerator InitializeBotResponseGenerator(params object[] instances)
        {
            var bootstrapper = new Bootstrapper(instances);
            var botResponseGenerator = bootstrapper.Get<IBotResponseGenerator>();
            return botResponseGenerator;
        }
    }
}