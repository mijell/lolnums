using System;
using System.Collections.Generic;
using System.Text;

namespace UserFacing.Tools
{
    internal class Architect
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

        public Champion()
        {
            name = "";
            baseStats = new BaseStats();
            status = new ChampionStatus();
        }

    }
}
