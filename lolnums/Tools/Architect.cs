using System;
using System.Collections.Generic;
using System.Text;

using UserFacing.Tools;
using ObjectLayer.Champion;

namespace UserFacing.Tools
{
    internal class Architect
    {

        ///////////////////////////
        /// Members
        //////////////////////////

        public ConfigReader configReader { get; set; }

        Dictionary<string, Champion> champDict { get; set; }

        ///////////////////////////
        /// Functions
        //////////////////////////

    }
}
