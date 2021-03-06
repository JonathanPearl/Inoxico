﻿using System;
using System.Collections.Generic;
using System.Text;


namespace Inoxico.TechnicalTest
{
    public class DeepestPitAnswer
    {

        public static int Solution(int[] points)
        {
            var peaks = GetPeakLocations(points);
            var pits = GetPitLocations(points); // Needs to be some logic here with difference
            var maximumpit = -1;
            var count = 0;
            while (count <= peaks.Length-1)
            {
                foreach (var pit in pits)
                {
                    if (peaks[count]<pit)
                        if (peaks[count+1]>pit)
                        {
                            var startingvalue = points[peaks[count]];
                            var pitValue = points[pit];
                            var endValue = points[peaks[count + 1]];
                            var newPitSize = PitDepth(new int[] { startingvalue, pitValue, endValue });
                            if (maximumpit < newPitSize) maximumpit = newPitSize;
                        }
                }
                count++;
            }
            return maximumpit;
        }

        public static bool IsPit(int[] locationValues)
        {
            if (locationValues[0] > locationValues[1]) 
            if (locationValues[2] > locationValues[1]) return true;
                return false;
        }

        public static int [] GetPeakLocations(int[] locationValues)
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

        public static IEnumerable<int> GetPitLocations(int[] locationValues)
        {
            var peakLocations = new List<int>();

            if (locationValues[0] < locationValues[1]) peakLocations.Add(0); // First Value Is Peak
            var count = 1;
            while (count < locationValues.Length - 1)
            {
                var currentLocation = new int[] { locationValues[count - 1], locationValues[count], locationValues[count + 1] };
                if (IsPit(currentLocation)) peakLocations.Add(count);

                count++;
            }

            if (locationValues[locationValues.Length - 1] < locationValues[locationValues.Length - 2]) peakLocations.Add(count); // Last Value Peak
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
