using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectLayer.Items.Legendary
{
    internal class SeryldasGrudge : Item
    {
        public override bool init()
        {
            bool flag = true;

            name = "Serylda's Grudge";

            bonus_ad = 45;
            bonus_abilityHaste = 20;
            bonus_armorPen = 30;

            itemClass = ItemClass.LEGENDARY_ITEM;

            return flag;
        }
    }
}