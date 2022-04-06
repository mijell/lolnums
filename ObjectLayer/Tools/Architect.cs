using Newtonsoft.Json.Linq;
using ObjectLayer.Champions;
using ObjectLayer.Items;
using System.Collections.Generic;
using System.IO;
using ConfigLayer.Tools;

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

        public Champion getFullChampion(string champion_name)
        {
            Champion rChampion = null;
            if (champion_name == "akshan")
            {
                rChampion = new Akshan();
            }

            return rChampion;
        }

        public void initArchitect(string configFilename)
        {
            //Read in config
            configReader.loadFile(configFilename);

            //Initialize champion dictionary
            initChampionDictionary();
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

        public Item getItemByName(string itemName)
        {
            Item item = null;

            if (itemName == "DivineBlunderer")
            {
                //Get pranked idiot
            }
            else
            {
                item = new Item();
                item.name = itemName;
            }

            return item;
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
        }
    }
}