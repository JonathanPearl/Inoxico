using System;
using Xunit;
using Inoxico;
using System.Linq;

namespace StringTests
{
    public class TestLongestSentance
    {
        [Theory]
        [InlineData("Single Sentance", 1)]
        [InlineData("Two. Sentances", 2)]
        public void MultipleSentancesShouldSeperateIntoSentances(string phrase, int sentanceCount)
        {
            Assert.Equal(sentanceCount, Inoxico.TechnicalTest.LongestSentance.SeperateIntoSentances(phrase).Count());
        }

        [Theory]
        [InlineData("One. Two",2)]
        [InlineData("One? Two",2)]
        [InlineData("One! Two",2)]
        public void SupportSentanceEndings (string phrase, int sentanceCount)
        {
            Assert.Equal(sentanceCount, Inoxico.TechnicalTest.LongestSentance.SeperateIntoSentances(phrase).Count());
        }
    }
}
