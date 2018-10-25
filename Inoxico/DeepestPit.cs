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
            var peakLocations = new List<int>();

            if (locationValues[0] > locationValues[1]) peakLocations.Add(0); // First Value Is Peak
            var count = 1;
            while (count < locationValues.Length-1)
            {
                var currentLocation = new int[] { locationValues[count - 1], locationValues[count], locationValues[count + 1] };
                if (IsPeak(currentLocation)) peakLocations.Add(count);

                count++;
            }
            

            if (locationValues[locationValues.Length-1] > locationValues[locationValues.Length - 2]) peakLocations.Add(count); // Last Value Peak
            return peakLocations.ToArray();
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
