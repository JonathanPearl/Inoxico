using System;
using Xunit;
using Inoxico;

namespace PitTests
{
    public class TestDeepestPit
    {
        [Theory]
        [InlineData(new int[] { 0, 1, 3,-2,0,1,0,-3,2,3 }, 4)]
        
        public void SolutionQueries(int[] locationValues, int maxPit)
        {
            Assert.Equal(maxPit, Inoxico.TechnicalTest.DeepestPitAnswer.Solution(locationValues));
        }

        [Theory]
        [InlineData (new int [] { 1,2,1}, new int [] { 1 } )]
        [InlineData(new int[] { 2, 0, 2 }, new int[] { 0,2 })]
        [InlineData(new int[] { 1, 2, 1  ,3 }, new int[] { 1,3 })]
        [InlineData(new int[] { -1, 0, 1, 2, -1 }, new int[] { 3 })]
        public void PeakInflectionLocations (int [] locationValues, int [] peakLocations)
        {
            Assert.Equal(peakLocations, Inoxico.TechnicalTest.DeepestPitAnswer.GetPeakLocations(locationValues));
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 1 }, new int[] { 0,2 })]
        [InlineData(new int[] { 2, 0, 2 }, new int[] { 1})]
        [InlineData(new int[] { 1, 2, 1, 3 }, new int[] {0,2 })]
        [InlineData(new int[] { -1, 0, -3, 2 }, new int[] { 0, 2 })]
  
        public void PitInflectionLocations(int[] locationValues, int[] peakLocations)
        {
            Assert.Equal(peakLocations, Inoxico.TechnicalTest.DeepestPitAnswer.GetPitLocations(locationValues));
        }


        [Theory]
       [InlineData (new int [] {1,2,1})]
       public void IsPeak (int [] locationValues) // This is important the deepest pit will always be along an inflection point
                                                               // Note We do cut out allot of pits in order to do this
                                                               // Inflection Points are Peaks and Valleys
        {
            Assert.True(Inoxico.TechnicalTest.DeepestPitAnswer.IsPeak(locationValues));
        }  

        [Theory]
        [InlineData (new int[] { 3, -2, 0 })]
        [InlineData(new int[] { 1, -3, 2 })] // Note This location Skips a Position - This should be kept in mind
        public void IsPit (int [] locationValues)
        {
            Assert.True(Inoxico.TechnicalTest.DeepestPitAnswer.IsPit(locationValues));
        }

        [Theory] // This is a counter Example to Test for Hills
        [InlineData(new int[] { 3, 5, 0 })]
        [InlineData(new int[] { 1, 3, 2 })]
        [InlineData(new int[] { 0, 0, 0 })] // Flat Surface
        public void LocationsThatAreNotPits(int[] locationVaues)
        {
            Assert.False(Inoxico.TechnicalTest.DeepestPitAnswer.IsPit(locationVaues));
        }

        [Theory]
        [InlineData(new int[] { 3, -2, 0 },2)]
        [InlineData(new int[] { 1, -3, 2 },4)]
        public void PitDepth(int[] locationVaues, int pitDepth)
        {
            Assert.Equal(pitDepth, Inoxico.TechnicalTest.DeepestPitAnswer.PitDepth(locationVaues));
        }
    }
}
