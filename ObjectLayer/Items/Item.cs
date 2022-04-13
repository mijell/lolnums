using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectLayer.Items
{
    public enum ItemClass
    {
        STARTER_ITEM,
        BASIC_ITEM,
        EPIC_ITEM,
        LEGENDARY_ITEM,
        MYTHIC_ITEM
    }

    public class Item
    {
        public double bonus_abilityHaste { get; set; }
        public double bonus_ad { get; set; }
        public double bonus_ap { get; set; }
        public double bonus_armor { get; set; }
        public double bonus_armorPen { get; set; }
        public double bonus_attackSpeed { get; set; }
        public double bonus_health { get; set; }
        public double bonus_lethality { get; set; }
        public double bonus_lifesteal { get; set; }
        public double bonus_mr { get; set; }
        public double bonus_omnivamp { get; set; }
        public ItemClass itemClass { get; set; }
        public string name { get; set; }

        public virtual double getBonusStat(string stat, double champion_base_ad)
        {
            double bonus_stat = 0.0;

            if (stat ==      "abilityHaste") { bonus_stat = bonus_abilityHaste; }
            else if (stat == "ad") { bonus_stat = bonus_ad; }
            else if (stat == "ap") { bonus_stat = bonus_ap; }
            else if (stat == "armor") { bonus_stat = bonus_armor; }
            else if (stat == "armorPen") { bonus_stat = bonus_armorPen; }
            else if (stat == "atkSpeed") { bonus_stat = bonus_attackSpeed; }
            else if (stat == "health") { bonus_stat = bonus_health; }
            else if (stat == "lethality") { bonus_stat = bonus_lethality; }
            else if (stat == "lifesteal") { bonus_stat = bonus_lifesteal; }
            else if (stat == "mr") { bonus_stat = bonus_mr; }
            else if (stat == "omnivamp") { bonus_stat = bonus_omnivamp; }

            return bonus_stat;
        }

        public virtual bool init()
        {
            bool flag = true;

            return flag;
        }

        public virtual void setMythicStats(int numLegendaryItems)
        {
        }
    }
}