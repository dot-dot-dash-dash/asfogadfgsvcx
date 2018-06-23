using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;

namespace MorseBot.Modules
{
    public class Ping : ModuleBase<SocketCommandContext>
    {

        [Command("say")]
        public async Task SayAsync([Remainder]string stuffToSay)
        {
            await ReplyAsync(stuffToSay);
        }

        [Command("how far away is Saturn?")]
        public async Task SaturnAsync()
        {
            await ReplyAsync("Why you you wanna know? Theres not even Oxygen there!");
        }


        [Command("how far away is Mars?")]
        public async Task MarsAsync()
        {
            await ReplyAsync("Why you you wanna know? Theres not even Oxygen there!");
        }

        [Command("how far away is the Moon?")]
        public async Task MoonAsync()
        {
            await ReplyAsync("Why you you wanna know? Theres not even Oxygen there!");
        }

        [Command("how far away is Venus?")]
        public async Task VenusAsync()
        {
            await ReplyAsync("Why you you wanna know? Theres not even Oxygen there!");
        }

        [Command("how far away is the Sun?")]
        public async Task SunAsync()
        {
            await ReplyAsync("Why do you wanna know? You will burn alive!");
        }

        [Command("how far away is Uranus?")]
        public async Task Uranus()
        {
            await ReplyAsync("It should be near your waist...");
        }

        [Command("how far away is Jupiter?")]
        public async Task Jupiter()
        {
            await ReplyAsync("Why you you wanna know? Theres not even Oxygen there!");
        }

        [Command("how far away is Mercury?")]
        public async Task Mercury()
        {
            await ReplyAsync("Why you you wanna know? Theres not even Oxygen there!");
        }

        [Command("how far away is Neptune?")]
        public async Task Neptune()
        {
            await ReplyAsync("Why you you wanna know? Theres not even Oxygen there!");
        }

        [Command("how far away is mars?")]
        public async Task Pluto()
        {
            await ReplyAsync("Why you you wanna know? Theres not even Oxygen there!");
        }

        [Command("help")]
        public async Task help()
        {
            var helpBuilder = new EmbedBuilder();

            helpBuilder.WithTitle("Help message");
            helpBuilder.AddInlineField("Ping", "Ping");
            helpBuilder.AddInlineField("Ask me how far away the planets are... I dare you", "how far away is (Planet)");
            helpBuilder.AddInlineField("Ask me what are the tasks", "what are the tasks");
            helpBuilder.AddInlineField("Ask me what the announcements are", "what are the announcements");
            helpBuilder.WithColor(Color.Blue);
            await Context.Channel.SendMessageAsync("", false, helpBuilder);
        }

        [Command("what are the tasks")]
        public async Task tasks()
        {
            await ReplyAsync("I dunno, ask Mee6");
        }

        [Command("Ping!")]
        public async Task ping()
        {
            await ReplyAsync("Pong!");
            await ReplyAsync("Thats what you wanted... right?");
        }

        [Command("what are the announcements?")]
        public async Task announce()
        {
            await ReplyAsync("check #announcements");
        }

    }
}
