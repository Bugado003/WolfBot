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
        [SlashCommand("ReactionRoleSetup", "I could just use carl-bot instead of this....")]
        public async Task ReactionRoleSetup(InteractionContext ctx)
        {

        }
    }
}
