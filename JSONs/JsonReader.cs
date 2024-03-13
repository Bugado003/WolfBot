//Pretty self-explanatory, right?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization.Metadata;
namespace LunariumWolf.JSONs
{
    internal class JsonReader
    {
        //Data that need to be extracted
        public string token { get; set; }
        public async Task Read()
        {
            //Use StreamReader to Read the Json
           using (StreamReader sr = new StreamReader("config.json"))
            {
                //raw json
                string json = await sr.ReadToEndAsync();
                //A bugfix
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    IncludeFields = true
                };

                //Extracted data
                JsonStructure data = JsonSerializer.Deserialize<JsonStructure>(json, options);
                //Set values
                this.token = data.token;
            }
        }
    }
    internal sealed class JsonStructure
    {
        //What is present in the Json
        public string token { get; set; }
    }
}