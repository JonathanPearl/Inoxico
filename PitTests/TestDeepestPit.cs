using System;
using Xunit;
using Inoxico;

namespace PitTests
{
    public class TestDeepestPit
    {
        [Theory]
        [InlineData (new int[] { 3, -2, 0 })]
        [InlineData(new int[] { 1, -3, 2 })] // Note This location Skips a Position - This should be kept in mind
        public void IsLocationPit(int [] locationVaues)
        {
            Assert.True(Inoxico.TechnicalTest.DeepestPitAnswer.IsLocationPit(locationVaues));
        }

        [Theory] // This is a counter Example to Test for Hills
        [InlineData(new int[] { 3, 5, 0 })]
        [InlineData(new int[] { 1, 3, 2 })]
        public void LocationsAreNotPits(int[] locationVaues)
        {
            Assert.False(Inoxico.TechnicalTest.DeepestPitAnswer.IsLocationPit(locationVaues));
        }

        [Theory]
        [InlineData(new int[] { 3, -2, 0 },2)]
        [InlineData(new int[] { 1, -3, 2 }, 4)]
        public void PitDepth(int[] locationVaues, int pitDepth)
        {
            Assert.Equal(pitDepth, Inoxico.TechnicalTest.DeepestPitAnswer.PitDepth(locationVaues));
        }
    }
}
