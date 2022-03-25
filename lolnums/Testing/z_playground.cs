using System;
using System.IO;

using lolnums.Tools;

using Newtonsoft.Json.Linq;

namespace lolnums.Testing
{
    internal class z_playground
    {
        public void play(ConfigReader config)
        {
            Console.WriteLine("Running Zacs's Playground.");


            string import_filename = "..\\input\\Champions_11_24.json";
            string jsonString = File.ReadAllText(import_filename);

            JObject myObj = JObject.Parse(jsonString);
            var champ = myObj["Aatrox"];

            Console.WriteLine(champ["stats"]["hp"]);
        }
    }
}
