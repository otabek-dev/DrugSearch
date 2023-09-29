using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace DrugSearch.Controllers
{
    [ApiController]
    [Route("/")]
    public class BotController : ControllerBase
    {
        private TelegramBotClient bot = Bot.GetTelegramBot();

        // GET: api/<BotController>
        [HttpGet]
        public string Get()
        {
            return "Telegram bot was started";
        }

        [HttpPost]
        public async void Post(Update update)
        {
            var txt = update.Message?.Text;
            long chatId = update.Message.Chat.Id;
            await bot.SendTextMessageAsync(chatId, txt);
        }
    }
}
