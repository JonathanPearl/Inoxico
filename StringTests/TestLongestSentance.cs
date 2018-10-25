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
        [InlineData("We test coders. Give us a try?", 3)]
        public void MultipleSentancesShouldSeperateIntoSentances(string phrase, int sentanceCount)
        {
            Assert.Equal(sentanceCount, Inoxico.TechnicalTest.LongestSentance.PhraseIntoSentances(phrase).Count());
        }

        [Theory]
        [InlineData("One. Two", 2)]
        [InlineData("One? Two", 2)]
        [InlineData("One! Two", 2)]
        public void SupportSentanceEndings(string phrase, int sentanceCount)
        {
            Assert.Equal(sentanceCount, Inoxico.TechnicalTest.LongestSentance.PhraseIntoSentances(phrase).Count());
        }

        [Theory]
        [InlineData("One Two Three", 3)]
        [InlineData("One Two Three ", 3)]
        public void GetWordsInSentance(string sentance, int wordCount)
        {
            Assert.Equal(wordCount, Inoxico.TechnicalTest.LongestSentance.SentaceIntoWords(sentance).Count());

        }

        [Theory]
        [InlineData(new string [] {"A"," ","B"}, new string [] { "A", "B" })]
        public void EmptyWordsShouldntExist(string [] sentance, string [] words)
        {
            Assert.Equal(words, Inoxico.TechnicalTest.LongestSentance.FilterEmptyWords(sentance));
        }


    }
}
