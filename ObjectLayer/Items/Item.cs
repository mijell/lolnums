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
        public double bonus_armorPen { get; set; }
        public double bonus_attackSpeed { get; set; }
        public double bonus_lethality { get; set; }
        public double bonus_lifesteal { get; set; }
        public double bonus_omnivamp { get; set; }
        public ItemClass itemClass { get; set; }
        public string name { get; set; }

        public virtual double getBonusAttackDamage(double champion_base_ad)
        {
            return bonus_ad;
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