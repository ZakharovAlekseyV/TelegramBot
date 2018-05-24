using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;
using TelegramBot;

namespace TelegramBot.Controllers
{
    [Produces("application/json")]
    [Route("api/Registrar")]
    public class RegistrarController : Controller
    {
        /*// GET: api/Registrar
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Registrar/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }*/
        
        // POST: api/Registrar
        [HttpPost]
        public void Post([FromBody]Update update)
        {
            var chatId = update.Message.Chat.Id; 
            var text = update.Message.Text;
            Console.WriteLine($"Текст из телеграм: {text}, Id чата: {chatId}");
        }
    }
}
