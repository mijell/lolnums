using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectLayer.Items.Mythic
{
    internal class Eclipse : Item
    {
        public override bool init()
        {
            bool flag = true;

            name = "Eclipse";

            bonus_ad = 55;
            bonus_lethality = 18;
            bonus_omnivamp = 8;

            itemClass = ItemClass.MYTHIC_ITEM;

            return flag;
        }

        public override void setMythicStats(int numLegendaryItems)
        {
            bonus_armorPen = 4 * numLegendaryItems;
        }
    }
}