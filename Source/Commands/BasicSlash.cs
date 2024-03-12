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
            try
            {
                ctx.Channel.SendMessageAsync(jsonReader.download);
            } catch(Exception E) //If not able to
            {
                ctx.Channel.SendMessageAsync("Ops, something went wrong");
            }
        }
    }
}
