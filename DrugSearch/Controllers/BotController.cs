using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

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
            if (txt == "test")
            {
                var webapp = new WebAppInfo();
                webapp.Url = "https://habr.com/ru/articles/666278/";
                InlineKeyboardMarkup inlineKeyboard = new(new[]
                {
                    // first row
                    new []
                    {
                        InlineKeyboardButton.WithCallbackData(text: "1.1", callbackData: "11"),
                        InlineKeyboardButton.WithCallbackData(text: "1.2", callbackData: "12"),
                    },
                    // second row
                    new []
                    {
                        InlineKeyboardButton.WithCallbackData(text: "2.1", callbackData: "21"),
                        InlineKeyboardButton.WithCallbackData(
                            text: "2.2",
                            callbackData: "22"
                            ),
                        InlineKeyboardButton.WithWebApp("test web app", webapp)
                    },
                });

                Message sentMessage = await bot.SendTextMessageAsync(
                    chatId: chatId,
                    text: "A message with an inline keyboard markup",
                    replyMarkup: inlineKeyboard,
                    cancellationToken: default);
            }
            await bot.SendTextMessageAsync(chatId, txt);
        }
    }
}
