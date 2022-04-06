using System;

namespace CalculationLayer
{
    public class CalcDamageInstance
    {
        public static int CalcPostMitigationDamage(int sourceDamage, int targetArmorOrMR)
        {
            int damageTaken;

            if (targetArmorOrMR >= 0)
            {
                damageTaken = sourceDamage * 100 / (100 + targetArmorOrMR);
            }
            else
            {
                damageTaken = sourceDamage * 2 - 100 / (100 - targetArmorOrMR);
            }

            return damageTaken;
        }
    }
}