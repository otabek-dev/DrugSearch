using Telegram.Bot;

namespace DrugSearch
{
    public static class Bot
    {
        private static TelegramBotClient client { get; set; }
        private static string botToken { get; } = "6610907585:AAHOSkQBq6W7ewmpURSIvmXesRVZh6nBWc8";
        public static string WebAppUrl { get; } = "https://master--brilliant-blini-a90b82.netlify.app";
        public static string BotUrlWithStartApp { get; } = "https://t.me/MiniDrugSearch_bot/drugapp?startapp=";

        public static TelegramBotClient GetTelegramBot()
        {
            if (client != null)
            {
                return client;
            }

            client = new TelegramBotClient(botToken);
            return client;
        }
    }
}
