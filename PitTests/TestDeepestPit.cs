using System;
using Xunit;
using Inoxico;

namespace PitTests
{
    public class TestDeepestPit
    {
        [Theory]
        [InlineData (new int[] { 3, -2, 0 })]
        [InlineData(new int[] { 1, -3, 2 })]
        public void IsLocationPit(int [] locationVaues)
        {
            Assert.True(Inoxico.TechnicalTest.DeepestPitAnswer.IsLocationPit(locationVaues));
        }

        [Theory]
        [InlineData(new int[] { 3, 5, 0 })]
        [InlineData(new int[] { 1, 3, 2 })]
        public void LocationsAreNotPits(int[] locationVaues)
        {
            Assert.False(Inoxico.TechnicalTest.DeepestPitAnswer.IsLocationPit(locationVaues));
        }

        [Theory]
        [InlineData(new int[] { 3, -2, 0 })]
        [InlineData(new int[] { 1, -3, 2 })]
        public void PitDepth(int[] locationVaues)
        {
            Assert.True(Inoxico.TechnicalTest.DeepestPitAnswer.IsLocationPit(locationVaues));
        }
    }
}
