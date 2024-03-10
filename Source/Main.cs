//Bot Startup
using DSharpPlus;
using LunariumWolf.JSONs;
using System;
//Create class "Bot"
internal class Bot
{
    //Get Discord Client
    private static DiscordClient Client { get; set; }
        static async Task Main(string[] args)
        {
        //Get JsonReader class
        var jsonReader = new JsonReader();
        //use the Read method
        await jsonReader.Read();
        //Get value from JsonReader
        string token = jsonReader.token;
        //Set Discord configuration
        var dConfig = new DiscordConfiguration()
        {
            Intents = DiscordIntents.All,
            Token = token,
            TokenType = TokenType.Bot,
            AutoReconnect = true
        };
        Client = new DiscordClient(dConfig);
        Client.Ready += Client_Ready;

        //Keep the bot Online forever (as long as the program is running)
        await Client.ConnectAsync();
        await Task.Delay(-1);
        }
    private static Task Client_Ready(object sender, EventArgs e)
    {
        return Task.CompletedTask;
    }
}