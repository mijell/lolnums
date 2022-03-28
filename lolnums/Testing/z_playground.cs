using System;
using System.IO;
using System.Collections.Generic;

using ObjectLayer.Champion;

using Newtonsoft.Json.Linq;

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
            Champion brand_copy = champDict["brand"].deepCopy();
            Console.WriteLine("Brand(dict) has " + champDict["brand"].baseStats.base_ad + " base attack damage");
            Console.WriteLine("Brand(obj)  has " + brand_copy.baseStats.base_ad + " base attack damage");

            Console.WriteLine("~~~~");
            brand_copy.baseStats.base_ad = 77;

            Console.WriteLine("Brand(dict) has " + champDict["brand"].baseStats.base_ad + " base attack damage");
            Console.WriteLine("Brand(obj)  has " + brand_copy.baseStats.base_ad + " base attack damage");

        }
    }
}
