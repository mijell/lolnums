using System;
using System.IO;
using System.Collections.Generic;
using lolnums.Tools;

using ObjectLayer.Champion;

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

            Dictionary<string, Champion> champDict = new Dictionary<string, Champion>();

            foreach (JProperty token in myObj.Children())
            {
                Champion nChampion = new Champion();
                nChampion.initChampionFromJson(token);

                champDict[nChampion.name.ToLower()] = nChampion;


            }

            foreach (KeyValuePair<string, Champion> champ in champDict)
            {
                Console.WriteLine(champ.Value.name + ":: Base AD = " + champ.Value.baseStats.base_ad);
            }

            Console.WriteLine("Ahri has " + champDict["Ahri"].baseStats.base_ad + " base attack damage");
        }
    }
}
