//Basically a "list" with all the basic slash commands
using DSharpPlus;
using DSharpPlus.Entities;
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
        //That one Carl-bot command command
        [SlashCommand("ReactionRoleSetup", "I could just use carl-bot instead of this....")]
        public async Task ReactionRoleSetup(InteractionContext ctx)
        {
            var member = ctx.Member;
            await ctx.Interaction.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent($"Hello {member}, why dont ya choose a channel for the reactionRole thing?"));
            
        }
    }
}
