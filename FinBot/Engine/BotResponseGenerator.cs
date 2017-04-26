using Syn.Bot.Siml;
using BotResponse = FinBot.Models.BotResponse;

namespace FinBot.Engine
{
    public interface IBotResponseGenerator
    {
        BotResponse GetBotResponse(string input);
    }

    public class BotResponseGenerator : IBotResponseGenerator
    {
        private readonly SimlBot _simlBot;
        private readonly IInputNormalizer _inputNormalizer;

        public BotResponseGenerator(IAdaptersRepository adaptersRepository, ISimlPackageLoader simlPackageLoader, IInputNormalizer inputNormalizer)
        {
            _inputNormalizer = inputNormalizer;
            _simlBot = new SimlBot();
            _simlBot.PackageManager.LoadFromString(simlPackageLoader.LoadSimlPackage());
            _simlBot.Adapters.AddRange(adaptersRepository.GetAdapters());
        }

        public BotResponse GetBotResponse(string input)
        {
            var normalizedInput = _inputNormalizer.Normalize(input);
            var chatResult = _simlBot.Chat(normalizedInput);

            return new BotResponse
            {
                ResponseText = chatResult.BotMessage
            };
        }
    }
}