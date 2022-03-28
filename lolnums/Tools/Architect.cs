using System;
using System.IO;
using System.Collections.Generic;

using Newtonsoft.Json.Linq;
using ObjectLayer.Champion;

namespace UserFacing.Tools
{
    internal class Architect
    {

        ///////////////////////////
        /// Members
        //////////////////////////

        public ConfigReader configReader { get; set; }

        public Dictionary<string, Champion> champDict { get; set; }

        ///////////////////////////
        /// Functions
        //////////////////////////

        public Architect()
        {
            configReader = new ConfigReader();
            champDict = new Dictionary<string, Champion>();
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
        }
    }
}
