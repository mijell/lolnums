using System;

using ObjectLayer.Tools;
using CalculationLayer;

namespace UserFacing.Testing
{
    internal class m_playground
    {
        public void play(Architect architect)
        {
            Console.WriteLine("Running Mitch's Playground.");

            int damageTaken = CalcDamageInstance.CalcPostMitigationDamage(1000, 25);

            Console.WriteLine("Total physical/magic damage after armor/MR: " + damageTaken);
        }
    }
}