using System;
using FinBot.Models;

namespace FinBot.Engine
{
    public class BotResponseGenerator : IBotResponseGenerator
    {
        public BotResponse GetBotResponse(string input)
        {
            return new BotResponse
            {
                ResponseText = string.Format("You said: {0}", input)
            };
        }
    }
}