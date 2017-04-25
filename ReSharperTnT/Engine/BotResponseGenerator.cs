using FinBot.Models;

namespace FinBot.Engine
{
    public class BotResponseGenerator : IBotResponseGenerator
    {
        public BotResponse GetBotResponse(string input)
        {
            return new BotResponse
            {
                ResponseText = $"You said: {input}"
            };
        }
    }
}