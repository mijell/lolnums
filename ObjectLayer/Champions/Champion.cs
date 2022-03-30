using Newtonsoft.Json.Linq;
using System;

namespace ObjectLayer.Champion
{
    /// <summary>
    /// Defines the initial parameters of a champion
    /// </summary>

    public class BaseStats
    {
        public double ad_per_level;
        public double armor_per_level;
        public double atkRange;
        public double atkSpeed;
        public double atkSpeed_per_leve;
        public double base_ad;
        public double base_armor;
        public double base_hp;
        public double base_hp_regen;
        public double base_mana;
        public double base_mana_regen;
        public double base_mr;
        public double crit;
        public double crit_per_level;
        public double hp_per_level;
        public double hp_regen_per_level;
        public double mana_per_level;
        public double movespeed;
        public double mr_per_level;
        public double regen_mana_per_level;

        public BaseStats copyShallow()
        {
            return (BaseStats)this.MemberwiseClone();
        }
    }

    /// <summary>
    /// A base class to be inhereted by the specific champions.
    /// </summary>
    public class Champion
    {
        public BaseStats baseStats { get; set; }

        public string name { get; set; }

        public ChampionStatus status { get; set; }

        public Champion()
        {
            name        = "";
            baseStats   = new BaseStats();
            status      = new ChampionStatus();
        }

        public Champion copyDeep()
        {
            Champion copy = new Champion();
            copy.baseStats = this.baseStats.copyShallow();
            copy.status = this.status.copyShallow();

            return copy;
        }

        public Champion copyShallow()
        {
            return (Champion)this.MemberwiseClone();
        }

        public void initChampionFromJson(JProperty jProperty)
        {
            name = jProperty.Name;

            if (jProperty.Value.Type == JTokenType.Object)
            {
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
        public int ability_power;
        public int armor;
        public int attack_damage;
        public int hp;
        public int level;
        public int magic_resist;
        public int mana;

        public int max_hp;
        public int max_mana;

        public ChampionStatus copyShallow()
        {
            return (ChampionStatus)this.MemberwiseClone();
        }
    }
}