using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using ConfigLayer.Tools;
using ObjectLayer.Items;
using ObjectLayer.Tools;

namespace ObjectLayer.Champions
{
    /// <summary>
    /// Defines the initial parameters of a champion
    /// </summary>

    public class BaseStats
    {
        public double ad_per_level;
        public double armor_per_level;
        public double atkRange;
        public double atkSpeed_per_level;
        public double base_ad;
        public double base_armor;
        public double base_atkSpeed;
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

        public List<Item> items { get; set; }
        public Architect myArchitect { get; set; }
        public string name { get; set; }

        public ChampionStatus status { get; set; }

        public Champion()
        {
            name        = "";
            baseStats   = new BaseStats();
            status      = new ChampionStatus();
            items       = new List<Item>();
            myArchitect = null;
        }

        public virtual void copyBase(Champion oChamp)
        {
            name      = oChamp.name;
            baseStats = oChamp.baseStats.copyShallow();
            status    = oChamp.status.copyShallow();
        }

        public virtual Champion copyDeep()
        {
            Champion copy = new Champion();
            copy.baseStats = this.baseStats.copyShallow();
            copy.status = this.status.copyShallow();

            return copy;
        }

        public virtual Champion copyShallow()
        {
            return (Champion)this.MemberwiseClone();
        }

        public int getNumLegendaryItems()
        {
            int num = 0;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].itemClass == ItemClass.LEGENDARY_ITEM)
                {
                    num++;
                }
            }

            return num;
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
                baseStats.atkSpeed_per_level    =  Convert.ToDouble(statsObject.Property("attackspeedperlevel").Value.ToString());
                baseStats.base_atkSpeed         =  Convert.ToDouble(statsObject.Property("attackspeed").Value.ToString());
                baseStats.atkRange              =  Convert.ToDouble(statsObject.Property("attackrange").Value.ToString());
                baseStats.movespeed             =  Convert.ToDouble(statsObject.Property("movespeed").Value.ToString());
            }
        }

        public virtual void parseMultiParameter(string key, List<string> multiValue)
        {
            foreach (string value in multiValue)
            {
                parseParameter(key, value);
            }
        }

        public virtual void parseParameter(string key, string value)
        {
            if (myArchitect != null)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (key == "Item") { items.Add(myArchitect.getItemByName(value)); }
                    else if (key == "ChampionLevel") { setChampionLevel(Int32.Parse(value)); }
                    else if (key == "Armor" || key == "MagicResist" || key == "Health") { setFixedStat(key, Convert.ToDouble(value)); }
                    else if (key == "example") { }
                }
            }
        }

        public virtual void printSummary()
        {
            string itemString = "";
            bool first_flag = true;
            foreach (Item item in items)
            {
                if (!first_flag) { itemString += "\n\t\t"; }
                itemString += item.name;
                first_flag = false;
            }

            Console.WriteLine(name);
            Console.WriteLine("\tLevel - " + status.level);
            Console.WriteLine("\tAD    - " + status.total_attack_damage);
            Console.WriteLine("\tArmor - " + status.total_armor);
            Console.WriteLine("\tMR    - " + status.total_magic_resist);
            Console.WriteLine("\tHP    - " + status.total_hp);
            Console.WriteLine("\tItems - " + itemString);
        }

        public double scaleStat(double base_stat, double growth_factor, int level_scale)
        {
            return base_stat + (growth_factor * level_scale * (0.7025 + 0.0175 * level_scale));
        }

        public void setChampionLevel(int _level)
        {
            int levelScale = _level - 1;
            status.level                     = _level;
            status.base_hp                  = scaleStat(baseStats.base_hp, baseStats.hp_per_level, levelScale);
            status.base_mana                = scaleStat(baseStats.base_mana, baseStats.mana_per_level, levelScale);
            status.base_armor               = scaleStat(baseStats.base_armor, baseStats.armor_per_level, levelScale);
            status.base_magic_resist        = scaleStat(baseStats.base_mr, baseStats.mr_per_level, levelScale);
            status.base_attack_damage       = scaleStat(baseStats.base_ad, baseStats.ad_per_level, levelScale);
            status.base_atkSpeed            = scaleStat(baseStats.base_atkSpeed, baseStats.atkSpeed_per_level, levelScale);
        }

        public virtual void setChampionLoadout(string parameter_string)
        {
            string level = ConfigReader.getParamFromLine(parameter_string, "ChampionLevel", "", true);

            parseParameter("ChampionLevel", ConfigReader.getParamFromLine(parameter_string, "ChampionLevel", "", true));
            parseMultiParameter("Item", ConfigReader.getMultiParamFromLine(parameter_string, "Item", true));
            parseParameter("Armor", ConfigReader.getParamFromLine(parameter_string, "Armor", "", true));
            parseParameter("MagicResist", ConfigReader.getParamFromLine(parameter_string, "MagicResist", "", true));
            parseParameter("Health", ConfigReader.getParamFromLine(parameter_string, "Health", "", true));

            int numLegendaryItems = getNumLegendaryItems();
            for (int i = 0; i < items.Count; i++)
            {
                items[i].setMythicStats(numLegendaryItems);
            }

            updateTotalStats();
        }

        public void setFixedStat(string statString, double value)
        {
            if (statString == "Armor") { status.base_armor = value; }
            else if (statString == "MagicResist") { status.base_magic_resist = value; }
            else if (statString == "Health") { status.base_hp = value; }
        }

        public void updateTotalStats()
        {
            //Calculate bonus attack damage from items and runes
            double dump = 0.0;

            for (int i = 0; i < items.Count; i++)
            {
                dump                                 += items[i].getBonusStat("abilityHaste", 0);
                status.bonus_attack_damage           += items[i].getBonusStat("ad", status.base_attack_damage);
                status.bonus_ability_power           += items[i].getBonusStat("ap", status.base_ability_power);
                status.bonus_armor                   += items[i].getBonusStat("armor", status.base_armor);
                dump                                 += items[i].getBonusStat("armorPen", 0);
                status.bonus_atkSpeed                += items[i].getBonusStat("atkSpeed", status.base_atkSpeed);
                status.bonus_hp                      += items[i].getBonusStat("health", status.base_hp);
                dump                                 += items[i].getBonusStat("lethality", 0);
                dump                                 += items[i].getBonusStat("lifesteal", 0);
                status.bonus_magic_resist            += items[i].getBonusStat("mr", status.base_magic_resist);
                dump                                 += items[i].getBonusStat("omnivamp", 0);
            }

            status.total_attack_damage = status.bonus_attack_damage + status.base_attack_damage;
            status.total_ability_power = status.bonus_ability_power + status.base_ability_power;
            status.total_armor         = status.bonus_armor         + status.base_armor;
            status.total_magic_resist  = status.bonus_magic_resist  + status.base_magic_resist;
            status.total_hp            = status.bonus_hp            + status.base_hp;
            status.total_atkSpeed      = status.bonus_atkSpeed      + status.base_atkSpeed;
        }
    }

    //A class defining the live parameters of a champion
    public class ChampionStatus
    {
        public double base_ability_power;
        public double base_armor;
        public double base_atkSpeed;
        public double base_attack_damage;
        public double base_hp;
        public double base_magic_resist;
        public double base_mana;
        public double bonus_ability_power;
        public double bonus_armor;
        public double bonus_atkSpeed;
        public double bonus_attack_damage;
        public double bonus_hp;
        public double bonus_magic_resist;
        public double bonus_mana;
        public double current_hp;
        public double current_mana;
        public double level;
        public double total_ability_power;
        public double total_armor;
        public double total_atkSpeed;
        public double total_attack_damage;
        public double total_hp;
        public double total_magic_resist;
        public double total_mana;

        public ChampionStatus copyShallow()
        {
            return (ChampionStatus)this.MemberwiseClone();
        }
    }
}