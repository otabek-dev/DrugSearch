using Microsoft.Extensions.Configuration;
using Telegram.Bot;

namespace DrugSearch
{
    public class Bot
    {
        private static TelegramBotClient client { get; set; }

        public static TelegramBotClient GetTelegramBot()
        {
            if (client != null)
            {
                return client;
            }

            client = new TelegramBotClient("6610907585:AAHOSkQBq6W7ewmpURSIvmXesRVZh6nBWc8");
            return client;
        }
    }
}
