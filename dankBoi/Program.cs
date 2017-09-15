using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace dankBoi
{
    class Program
    {
        public static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();

        private DiscordSocketClient dankBoi;

        public async Task MainAsync()
        {
            dankBoi = new DiscordSocketClient();

            dankBoi.Log += Log;
            dankBoi.MessageReceived += MessageReceived;

            string token = "MzU4MzA2Mjk2MDAyNTEwODQ5.DJ2p3g.tOkY8ahSn32g6AvghELQyGZOs5s";
            string usertoken = "MTkzNTE4MzUxMTAyOTAyMjcy.DJ15sQ.7gd9aqArIhicqL3l0_JxJWVLncA";
            await dankBoi.LoginAsync(TokenType.Bot, token);
            await dankBoi.StartAsync();
            await Task.Delay(-1);
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }

        private async Task MessageReceived(SocketMessage message)
        {
            if (message.Content == "Omae wa mou shindeiru")
            {
                await message.Channel.SendMessageAsync("NANI?!");
            }
        }
    }
}
