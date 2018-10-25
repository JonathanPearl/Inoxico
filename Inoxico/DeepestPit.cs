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

        public static int PitDepth(int[] locationValues)
        {

            // Get the minimum Value 
            var depth1 = locationValues[0] - locationValues[1];
            var depth2 = locationValues[2] - locationValues[1];
            var minDepth = depth1 < depth2 ? depth1 : depth2;
            return minDepth;
        }
    }
}
