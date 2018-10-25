using System;
using Xunit;
using Inoxico;
using System.Linq;

namespace StringTests
{
    public class TestStrings
    {
        [Theory]
        [InlineData("Single Sentance", 1)]
        public void MultipleSentancesShouldSeperateIntoSentances(string sentance, int sentanceCount)
        {
            Assert.Equal(sentanceCount, Inoxico.Strings.SeperateSentances(sentance).Count());
        }
    }
}
