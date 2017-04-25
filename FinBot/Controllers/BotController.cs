using System.Web.Http;
using FinBot.Engine;
using FinBot.Models;

namespace FinBot.Controllers
{
    public class BotController : ApiController
    {
        private readonly IBotResponseGenerator _botResponseGenerator;

        public BotController(IBotResponseGenerator botResponseGenerator)
        {
            _botResponseGenerator = botResponseGenerator;
        }


        // GET api/bot
        [HttpGet]
        public BotResponse Get([FromUri] string input)
        {
            return _botResponseGenerator.GetBotResponse(input);
        }
    }
}