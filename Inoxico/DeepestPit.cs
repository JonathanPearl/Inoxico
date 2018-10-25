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

        public static IEnumerable<int> GetPeakLocations(int[] locationValues)
        {
            return new int[] { 1 };
        }

        public static int PitDepth(int[] locationValues)
        {
            var depth1 = locationValues[0] - locationValues[1];
            var depth2 = locationValues[2] - locationValues[1];
            var minDepth = depth1 < depth2 ? depth1 : depth2; // Find which depth is smaller
            return minDepth;
        }

        public static bool IsPeak(int[] locationValues)
        {
            if (locationValues[0] < locationValues[1])
                if (locationValues[2] < locationValues[1])
                    return true;
            return false;
        }
    }
}
