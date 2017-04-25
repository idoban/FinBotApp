using FinBot.Models;

namespace FinBot.Engine
{
    public interface IBotResponseGenerator
    {
        BotResponse GetBotResponse(string input);
    }
}