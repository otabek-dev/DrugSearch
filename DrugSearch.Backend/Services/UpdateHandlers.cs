using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InlineQueryResults;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using DrugSearch.ViewModel;

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
                { InlineQuery: { } inlineQuery } => BotOnInlineQueryReceived(inlineQuery, cancellationToken),
                { EditedMessage: { } message } => BotOnMessageReceived(message, cancellationToken),
                { CallbackQuery: { } callbackQuery } => BotOnCallbackQueryReceived(callbackQuery, cancellationToken),
                { ChosenInlineResult: { } chosenInlineResult } => BotOnChosenInlineResultReceived(chosenInlineResult, cancellationToken),
                _ => UnknownUpdateHandlerAsync(update, cancellationToken)
            };

            await handler;
        }
        
        private async Task BotOnMessageReceived(Message message, CancellationToken cancellationToken)
        {
            if (message.Text is not { } messageText)
                return;

            if (message.ViaBot is not null)
                return;
            
            var action = messageText switch
            {
                "/start" => StartAction(_botClient, message, cancellationToken),
                _ => SendInlineKeyboardWithWebApp(_botClient, message, cancellationToken)
            };

            Message sentMessage = await action;

            static async Task<Message> StartAction(ITelegramBotClient botClient, Message message, CancellationToken cancellationToken)
            {
                await botClient.SendChatActionAsync(
                    chatId: message.Chat.Id,
                    chatAction: ChatAction.Typing,
                    cancellationToken: default);

                InlineKeyboardMarkup inlineKeyboard = new(
                    new[]
                    {
                        new[]
                        {
                            InlineKeyboardButton.WithSwitchInlineQuery("Switch inline query")
                        },
                        new[]
                        {
                            InlineKeyboardButton.WithSwitchInlineQueryCurrentChat("Inline query current chat")
                        }
                    });

                return await botClient.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    text: "Welcome to DrugSearch bot.\nSend a drug name or press the button to start Inline Query:",
                    replyMarkup: inlineKeyboard,
                    cancellationToken: default);
            }

            static async Task<Message> SendInlineKeyboardWithWebApp(ITelegramBotClient botClient, Message message, CancellationToken cancellationToken)
            {
                await botClient.SendChatActionAsync(
                    chatId: message.Chat.Id,
                    chatAction: ChatAction.Typing,
                    cancellationToken: default);

                var drug = message.Text?.Replace(' ', '-');

                var webAppInfo = new WebAppInfo() { Url = $"{Bot.WebAppUrl}/{drug}"};

                InlineKeyboardMarkup inlineKeyboard = new(InlineKeyboardButton.WithWebApp("Results", webAppInfo));
                
                return await botClient.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    text: "Click on the button to see the results",
                    replyMarkup: inlineKeyboard,
                    cancellationToken: default);
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
                List<DrugViewModel> drugs;
                if (inlineQuery.Query is "")
                    drugs = _drugSearchService.GetAllDrugs();
                else
                    drugs = _drugSearchService.SearchDrugs(inlineQuery.Query);

                var results = InlineQueryResult(drugs);

                await _botClient.AnswerInlineQueryAsync(
                    inlineQueryId: inlineQuery.Id,
                    results: results, 
                    cacheTime: 0,
                    isPersonal: true,
                    cancellationToken: default);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private List<InlineQueryResult> InlineQueryResult(List<DrugViewModel> drugs)
        {
            List<InlineQueryResult> results = new();
            foreach (var drug in drugs)
            {
                var resultTextMarkdown = $"[{drug.Name}]({Bot.BotUrlWithStartApp}{drug.Id})\n\n{drug.Description}";

                var article = new InlineQueryResultArticle(
                id: Guid.NewGuid().ToString(),
                title: drug.Name,
                inputMessageContent: new InputTextMessageContent(resultTextMarkdown) { ParseMode = ParseMode.Markdown });

                article.Description = drug.Description;
                article.ThumbnailUrl = "https://loremflickr.com/300/300/medicament";
                article.ThumbnailWidth = 300;
                article.ThumbnailHeight = 300;

                results.Add(article);
            }

            return results;
        }

        private async Task BotOnChosenInlineResultReceived(ChosenInlineResult chosenInlineResult, CancellationToken cancellationToken)
        {
            await _botClient.SendTextMessageAsync(
                chatId: chosenInlineResult.From.Id,
                text: $"You chose result with Id: {chosenInlineResult.ResultId}",
                cancellationToken: default);
        }

        private Task UnknownUpdateHandlerAsync(Update update, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
