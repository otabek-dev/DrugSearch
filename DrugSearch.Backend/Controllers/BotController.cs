using DrugSearch.Services;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;

namespace DrugSearch.Controllers
{
    [ApiController]
    [Route("/")]
    public class BotController : ControllerBase
    {
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
    }
}
