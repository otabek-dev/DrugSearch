using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InlineQueryResults;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;

namespace DrugSearch.Services
{
    public class UpdateHandlers
    {
        private TelegramBotClient _botClient = Bot.GetTelegramBot();
        private DrugService _drugSearchService;

        public UpdateHandlers(DrugService drugSearchService)
        {
            _drugSearchService = drugSearchService;
        }

        public async Task HandleUpdateAsync(Update update, CancellationToken cancellationToken)
        {
            var handler = update switch
            {
                { Message: { } message } => BotOnMessageReceived(message, cancellationToken),
                { EditedMessage: { } message } => BotOnMessageReceived(message, cancellationToken),
                { CallbackQuery: { } callbackQuery } => BotOnCallbackQueryReceived(callbackQuery, cancellationToken),
                { InlineQuery: { } inlineQuery } => BotOnInlineQueryReceived(inlineQuery, cancellationToken),
                { ChosenInlineResult: { } chosenInlineResult } => BotOnChosenInlineResultReceived(chosenInlineResult, cancellationToken),
                _ => UnknownUpdateHandlerAsync(update, cancellationToken)
            };

            await handler;
        }

        private async Task BotOnMessageReceived(Message message, CancellationToken cancellationToken)
        {
            if (message.Text is not { } messageText)
                return;

            var action = messageText switch
            {
                "/start" => StartAction(_botClient, message, cancellationToken),
                "Inline mode" => StartInlineQuery(_botClient, message, cancellationToken),
                _ => SendInlineKeyboardWithWebApp(_botClient, message, cancellationToken)
            };

            

            Message sentMessage = await action;

            static async Task<Message> StartAction(ITelegramBotClient botClient, Message message, CancellationToken cancellationToken)
            {
                await botClient.SendChatActionAsync(
                    chatId: message.Chat.Id,
                    chatAction: ChatAction.Typing,
                    cancellationToken: cancellationToken);

                ReplyKeyboardMarkup replyKeyboard = new( new KeyboardButton("Inline mode"));

                replyKeyboard.ResizeKeyboard = true;

                return await botClient.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    text: "Welcome to Telegram Bot DrugSearch.\nSend a drug name or select a section:",
                    replyMarkup: replyKeyboard,
                    cancellationToken: cancellationToken);
            }

            static async Task<Message> SendInlineKeyboardWithWebApp(ITelegramBotClient botClient, Message message, CancellationToken cancellationToken)
            {
                await botClient.SendChatActionAsync(
                    chatId: message.Chat.Id,
                    chatAction: ChatAction.Typing,
                    cancellationToken: cancellationToken);

                var drug = message.Text?.Replace(' ', '-');

                var webAppInfo = new WebAppInfo() { Url = $"{Bot.WebAppUrl}/{drug}"};

                InlineKeyboardMarkup inlineKeyboard = new(InlineKeyboardButton.WithWebApp("Results", webAppInfo));
                
                return await botClient.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    text: "Click on the button to see the results",
                    replyMarkup: inlineKeyboard,
                    cancellationToken: cancellationToken);
            }

            static async Task<Message> StartInlineQuery(ITelegramBotClient botClient, Message message, CancellationToken cancellationToken)
            {
                InlineKeyboardMarkup inlineKeyboard = new(
                    new[]
                    {
                        new[]
                        {
                            InlineKeyboardButton.WithSwitchInlineQueryCurrentChat("Inline query current chat")
                        }
                    });

                return await botClient.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    text: "Press the button to start Inline Query or\nSend a drug name or select a section:",
                    replyMarkup: inlineKeyboard,
                    cancellationToken: cancellationToken);
            }
        }

        private async Task BotOnCallbackQueryReceived(CallbackQuery callbackQuery, CancellationToken cancellationToken)
        {
            await _botClient.AnswerCallbackQueryAsync(
                callbackQueryId: callbackQuery.Id,
                text: $"Received {callbackQuery.Data}",
                cancellationToken: cancellationToken);

            await _botClient.SendTextMessageAsync(
                chatId: callbackQuery.Message!.Chat.Id,
                text: $"Received {callbackQuery.Data}",
                cancellationToken: cancellationToken);
        }

        private async Task BotOnInlineQueryReceived(InlineQuery inlineQuery, CancellationToken cancellationToken)
        {
            try
            {
                if (inlineQuery.Query is "") 
                    return;

                List<InlineQueryResult> results = new();

                var drugs = _drugSearchService.SearchDrugs(inlineQuery.Query);

                foreach (var drug in drugs)
                {
                    var article = new InlineQueryResultArticle(
                    id: Guid.NewGuid().ToString(),
                    title: drug.Name,
                    inputMessageContent: new InputTextMessageContent(drug.Name));

                    article.Description = drug.Description;
                    article.ThumbnailUrl = "https://loremflickr.com/300/300/medicament";
                    article.ThumbnailWidth = 300;
                    article.ThumbnailHeight = 300;

                    var webAppInfo = new WebAppInfo() { Url = $"{Bot.WebAppUrl}/drug/{drug.Id}" };
                    article.ReplyMarkup = new(InlineKeyboardButton.WithWebApp("Result", webAppInfo));

                    results.Add(article);
                }

                await _botClient.AnswerInlineQueryAsync(
                    inlineQueryId: inlineQuery.Id,
                    results: results, 
                    cacheTime: 0,
                    isPersonal: true,
                    cancellationToken: cancellationToken);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private async Task BotOnChosenInlineResultReceived(ChosenInlineResult chosenInlineResult, CancellationToken cancellationToken)
        {
            await _botClient.SendTextMessageAsync(
                chatId: chosenInlineResult.From.Id,
                text: $"You chose result with Id: {chosenInlineResult.ResultId}",
                cancellationToken: cancellationToken);
        }

        private Task UnknownUpdateHandlerAsync(Update update, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
