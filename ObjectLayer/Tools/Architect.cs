using Newtonsoft.Json.Linq;
using ObjectLayer.Champions;
using ObjectLayer.Items;
using System.Collections.Generic;
using System.IO;
using ConfigLayer.Tools;
using System;
using ObjectLayer.Items.Mythic;
using ObjectLayer.Items.Legendary;

namespace ObjectLayer.Tools
{
    public class Architect
    {
        public Dictionary<string, Champion> champDict { get; set; }

        public ConfigReader configReader { get; set; }

        public Architect()
        {
            configReader = new ConfigReader();
            champDict = new Dictionary<string, Champion>();
        }

        public Champion getChampionByName(string championName)
        {
            Champion champion = null;

            if (championName == "akshan")
            {
                champion = new Akshan();
            }
            else
            {
                champDict.TryGetValue(championName, out champion);
            }

            if (champion != null)
            {
                //Copy in the base stats
                champion.copyBase(champDict[championName.ToLower()]);
                champion.myArchitect = this;
            }

            return champion;
        }

        public Champion getFullChampion(string champion_name)
        {
            Champion rChampion = null;
            if (champion_name == "akshan")
            {
                rChampion = new Akshan();
            }

            return rChampion;
        }

        public Item getItemByName(string itemName)
        {
            Item item = null;

            if (String.Equals("Eclipse", itemName, StringComparison.OrdinalIgnoreCase))
            {
                item = new Eclipse();
            }
            else if (String.Equals("Botrk", itemName, StringComparison.OrdinalIgnoreCase))
            {
                item = new Botrk();
            }
            else if (String.Equals("SeryldasGrudge", itemName, StringComparison.OrdinalIgnoreCase))
            {
                item = new SeryldasGrudge();
            }
            else
            {
                item = new Item();
                item.name = itemName + " - ??";
            }

            item.init();

            return item;
        }

        public void initArchitect(string configFilename)
        {
            //Read in config
            configReader.loadFile(configFilename);

            //Initialize champion dictionary
            initChampionDictionary();
        }

        private void initChampionDictionary()
        {
            string jsonString = File.ReadAllText(configReader.championJsonFilename);

            JObject myObj = JObject.Parse(jsonString);

            foreach (JProperty token in myObj.Children())
            {
                Champion nChampion = new Champion();
                nChampion.initChampionFromJson(token);

                champDict[nChampion.name.ToLower()] = nChampion;
            }

            //Add target dummy
            Champion tdChampion = new Champion();
            tdChampion.name = "Target Dummy";
            champDict["targetdummy"] = tdChampion;
        }
    }
}