
using System;
using System.IO;
using System.Text.Json;
using ObjectLayer.Champions;

using Newtonsoft.Json.Linq;

namespace lolnums
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = "..\\..\\..";
            Directory.SetCurrentDirectory(dir);

            string import_filename = "..\\input\\Champions_11_24.json";
            string jsonString = File.ReadAllText(import_filename);

            JObject myObj = JObject.Parse(jsonString);
            var champ = myObj["Aatrox"];

            Console.WriteLine(champ["stats"]["hp"]);

        }
    }
}
