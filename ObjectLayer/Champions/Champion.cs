using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectLayer.Champions
{
    public class Champion
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Stats Stats { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Stats
    {
        public int hp { get; set; }
        public int hpperlevel { get; set; }
        public int mp { get; set; }
        public int mpperlevel { get; set; }
        public int movespeed { get; set; }
        public int armor { get; set; }
        public double armorperlevel { get; set; }
        public int spellblock { get; set; }
        public double spellblockperlevel { get; set; }
        public int attackrange { get; set; }
        public int hpregen { get; set; }
        public double hpregenperlevel { get; set; }
        public double mpregen { get; set; }
        public double mpregenperlevel { get; set; }
        public int crit { get; set; }
        public int critperlevel { get; set; }
        public int attackdamage { get; set; }
        public double attackdamageperlevel { get; set; }
        public double attackspeedperlevel { get; set; }
        public double attackspeed { get; set; }
    }
}
