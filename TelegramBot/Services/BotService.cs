using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Telegram.Bot;

namespace TelegramBot.Services
{
    public class BotService : IBotService
    {
        private readonly BotConfiguration _config;

        public TelegramBotClient Client { get; }

        public BotService(IOptions<BotConfiguration> config)
        {
            
            _config = config.Value;
            Client = new TelegramBotClient(_config.BotToken);
        }

        
    }
}
