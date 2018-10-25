using System;
using System.Collections.Generic;
using System.Text;


namespace Inoxico.TechnicalTest
{
    public class DeepestPitAnswer
    {
        public static bool IsLocationPit(int[] locationValues)
        {
            if (locationValues[0] > locationValues[1]) 
            if (locationValues[2] > locationValues[1]) return true;
                return false;
        }
    }
}
