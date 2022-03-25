using System;

using Newtonsoft.Json.Linq;

namespace ObjectLayer.Champion
{
    public class Champion
    {
        ///////////////////////////
        /// Members
        //////////////////////////

        public string name { get; set; }
        
        public ChampionStatus status { get; set; }

        public BaseStats baseStats { get; set; }

        ///////////////////////////
        /// Functions
        //////////////////////////

        public Champion ()
        {
            name        = "";
            baseStats   = new BaseStats ();   
            status      = new ChampionStatus ();
        }

        public void initChampionFromJson(JProperty jProperty)
        {
            name = jProperty.Name;

            if (jProperty.Value.Type == JTokenType.Object) { 
                JObject jObject = (JObject)jProperty.Value;
                JObject statsObject = (JObject)(jObject["stats"]);


                baseStats.base_hp               =  Convert.ToDouble(statsObject.Property("hp").Value.ToString());
                baseStats.hp_per_level          =  Convert.ToDouble(statsObject.Property("hpperlevel").Value.ToString());
                baseStats.base_mana             =  Convert.ToDouble(statsObject.Property("mp").Value.ToString());
                baseStats.mana_per_level        =  Convert.ToDouble(statsObject.Property("mpperlevel").Value.ToString());
                baseStats.base_hp_regen         =  Convert.ToDouble(statsObject.Property("hpregen").Value.ToString());
                baseStats.hp_regen_per_level    =  Convert.ToDouble(statsObject.Property("hpregenperlevel").Value.ToString());
                baseStats.base_mana_regen       =  Convert.ToDouble(statsObject.Property("mpregen").Value.ToString());
                baseStats.regen_mana_per_level  =  Convert.ToDouble(statsObject.Property("mpregenperlevel").Value.ToString());
                baseStats.base_armor            =  Convert.ToDouble(statsObject.Property("armor").Value.ToString());
                baseStats.armor_per_level       =  Convert.ToDouble(statsObject.Property("armorperlevel").Value.ToString());
                baseStats.base_mr               =  Convert.ToDouble(statsObject.Property("spellblock").Value.ToString());
                baseStats.mr_per_level          =  Convert.ToDouble(statsObject.Property("spellblockperlevel").Value.ToString());
                baseStats.crit                  =  Convert.ToDouble(statsObject.Property("crit").Value.ToString());
                baseStats.crit_per_level        =  Convert.ToDouble(statsObject.Property("critperlevel").Value.ToString());
                baseStats.base_ad               =  Convert.ToDouble(statsObject.Property("attackdamage").Value.ToString());
                baseStats.ad_per_level          =  Convert.ToDouble(statsObject.Property("attackdamageperlevel").Value.ToString());
                baseStats.atkSpeed              =  Convert.ToDouble(statsObject.Property("attackspeedperlevel").Value.ToString());
                baseStats.atkSpeed_per_leve     =  Convert.ToDouble(statsObject.Property("attackspeed").Value.ToString());
                baseStats.atkRange              =  Convert.ToDouble(statsObject.Property("attackrange").Value.ToString());
                baseStats.movespeed             =  Convert.ToDouble(statsObject.Property("movespeed").Value.ToString());
            }

        }

        public void setChampionLevel(int _level)
        {


        }

    }

    //A class defining the live parameters of a champion
    public class ChampionStatus
    {
        public int level;

        public int hp;
        public int mana;

        public int max_hp;
        public int max_mana;

        public int attack_damage;
        public int ability_power;

        public int armor;
        public int magic_resist;
    }


    //A class defining the base parameters of a champion
    public class BaseStats
    {
        public double base_hp;
        public double hp_per_level;

        public double base_mana;
        public double mana_per_level;

        public double base_hp_regen;
        public double hp_regen_per_level;

        public double base_mana_regen;
        public double regen_mana_per_level;

        public double base_armor;
        public double armor_per_level;

        public double base_mr;
        public double mr_per_level;

        public double base_ad;
        public double ad_per_level;

        public double crit;
        public double crit_per_level;

        public double atkSpeed;
        public double atkSpeed_per_leve;

        public double movespeed;
        public double atkRange;

    }

}
