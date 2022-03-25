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
            List<Champion> champList = new List<Champion>();

            foreach (JProperty token in myObj.Children())
            {
                Champion nChampion = new Champion();
                nChampion.initChampionFromJson(token);

                champList.Add(nChampion);

            }

            foreach (Champion champ in champList)
            {
                Console.WriteLine(champ.name + ":: Base AD = " + champ.baseStats.base_ad);
            }
        }
    }
}
