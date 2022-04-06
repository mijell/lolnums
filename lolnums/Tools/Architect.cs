﻿using Newtonsoft.Json.Linq;
using ObjectLayer.Champions;
using System.Collections.Generic;
using System.IO;
using ConfigLayer.Tools;

namespace UserFacing.Tools
{
    internal class Architect
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

            if (champion != null)
            {
                //Copy in the base stats
                champion.copyStats(champDict[championName.ToLower()]);
            }

            return champion;
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