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
        public string download { get; set; }
        public async Task Read()
        {
            //Use StreamReader to Read the Json
           using (StreamReader sr = new StreamReader("config.json"))
            {
                //try to extract the data
                try
                {
                    //raw json
                    string json = await sr.ReadToEndAsync();

                    //Extracted data
                    JsonStructure data = JsonSerializer.Deserialize<JsonStructure>(json);
                    //Set values
                    this.token = data.token;
                    this.download = data.download;
                }
                catch (Exception E) //if not able to, Check what went wrong
                {
                    //Check if config.json exists
                    if (File.Exists(@"config.json") == false)
                    {
                        //then tell the user and wait until the error is fixed
                        Console.WriteLine("config.json file is missing");
                        while(File.Exists(@"config.json") == false)
                        {
                            //Continue the loop until the error is fixed
                        }
                    }
                    else //if some data is missing
                    {
                        Console.WriteLine("Something is missing in the config.json File");
                        while(E != null)
                        {
                            //Wait for the data that's missing
                        }
                    }
                    Read();
                }
            }
        }
    }
    internal sealed class JsonStructure
    {
        //What is present in the Json
        public string token { get; set; }
        public string download { get; set; }
    }
}