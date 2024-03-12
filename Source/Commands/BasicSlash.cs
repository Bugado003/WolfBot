//Basically a "list" with all the basic slash commands
using DSharpPlus.SlashCommands;
using LunariumWolf.JSONs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunariumWolf.Source.Commands
{
    internal class BasicSlash : ApplicationCommandModule
    {
        //Download command
        [SlashCommand("Get Download", "Someone's pc has to execute its commands")]
        public async Task Download(InteractionContext ctx)
        {
            var jsonReader = new JsonReader();
            jsonReader.Read();
            //Try to send the file
                if (jsonReader.download != "download")
                {
                    await ctx.Channel.SendMessageAsync(jsonReader.download);
                }
                else //if cant get the Download link
                {
                    await ctx.Channel.SendMessageAsync("Oops, could not get the Download link");
                }
        }
    }
}
