using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;

namespace DrugSearch.Controllers
{
    [ApiController]
    [Route("/")]
    public class BotController : ControllerBase
    {
        // GET: api/<BotController>
        [HttpGet]
        public string Get()
        {
            return "Telegram bot was started";
        }

        [HttpPost]
        public void Post(Update update)
        {
            Console.WriteLine(update.Message?.Text);
        }
    }
}
