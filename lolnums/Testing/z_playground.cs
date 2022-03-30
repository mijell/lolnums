using ObjectLayer.Champion;
using System;
using System.Collections.Generic;
using UserFacing.Tools;

namespace UserFacing.Testing
{
    internal class z_playground
    {
        public void play(Architect architect)
        {
            Console.WriteLine("Running Zacs's Playground.");

            Dictionary<string, Champion> champDict = architect.champDict;

            //Test code
            Champion brand_copy = champDict["brand"].copyDeep();
            Console.WriteLine("Brand(dict) has " + champDict["brand"].baseStats.base_ad + " base attack damage");
            Console.WriteLine("Brand(obj)  has " + brand_copy.baseStats.base_ad + " base attack damage");

            Console.WriteLine("~~~~");
            brand_copy.baseStats.base_ad = 77;

            Console.WriteLine("Brand(dict) has " + champDict["brand"].baseStats.base_ad + " base attack damage");
            Console.WriteLine("Brand(obj)  has " + brand_copy.baseStats.base_ad + " base attack damage");
        }
    }
}