using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EchoBot1.Middleware
{
    public class Middleware1 : IMiddleware
    {
        public async Task OnTurnAsync(ITurnContext turnContext, NextDelegate next, CancellationToken cancellationToken = default)
        {
            await turnContext.SendActivityAsync($"[Middleware#1 {turnContext.Activity.Type}/OnTurn/Before");
            await next();
            await turnContext.SendActivityAsync($"[Middleware#2] {turnContext.Activity.Type}/OnTurn/After");
        }
    }
}
