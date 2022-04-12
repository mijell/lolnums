using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectLayer.Items.Legendary
{
    internal class Botrk : Item
    {
        public override bool init()
        {
            bool flag = true;

            name = "Blade of the Ruined King";

            bonus_ad = 40;
            bonus_attackSpeed = 25;
            bonus_lifesteal = 8;

            itemClass = ItemClass.LEGENDARY_ITEM;

            return flag;
        }
    }
}