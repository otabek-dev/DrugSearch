using DrugSearch.Services;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace DrugSearch.Controllers
{
    [ApiController]
    [Route("/")]
    public class BotController : ControllerBase
    {
        private TelegramBotClient bot = Bot.GetTelegramBot();

        [HttpGet]
        public string Get()
        {
            return "Telegram bot was started";
        }

        [HttpPost]
        public async void Post(
            [FromBody] Update update, 
            [FromServices] UpdateHandlers handleUpdateService, 
            CancellationToken cancellationToken)
        {
            await handleUpdateService.HandleUpdateAsync(update, cancellationToken);
        }

        #region Test code
        /*
        var txt = update.Message?.Text;
        long chatId = 0;
        long.TryParse(update.Message.Chat.Id.ToString() ?? "", out chatId);

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

            await bot.SendTextMessageAsync(
                chatId: chatId,
                text: "A message with an inline keyboard markup",
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }
        else
            await bot.SendTextMessageAsync(chatId, txt); */
        #endregion
    }
}
