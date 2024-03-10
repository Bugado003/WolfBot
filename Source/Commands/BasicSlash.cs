//Basically a "list" with all the slash commands
using DSharpPlus.SlashCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunariumWolf.Source.Commands
{
    internal class BasicSlash : ApplicationCommandModule
    {
        [SlashCommand("Register/ReacionRole", "Yea u could just use carl bot but are using this")]
        public async Task Register(InteractionContext ctx)
        {

        }
    }
}
