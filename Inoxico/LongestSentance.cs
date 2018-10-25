using System;
using System.Collections.Generic;

namespace Inoxico.TechnicalTest
{
    public class LongestSentanceAnswer
    {
        public static int Solution(string phrase)
        {
            var sentances = PhraseIntoSentances(phrase);
            var maximumWords = 0;
            foreach (var sentance in sentances)
            {
                var words = SentaceIntoWords(sentance);
                if (words.Length > maximumWords )
                {
                    maximumWords = words.Length;
                }
            }
            return maximumWords;
        }

        public static IEnumerable<string> PhraseIntoSentances(string phrase)
        {

            var sentanceEndings = new char[] { '.', '!', '?' };
            var sentances = phrase.Split(sentanceEndings);
            return sentances;

        }



        public static string [] SentaceIntoWords(string sentance)
        {
            var wordSplitter = ' ';
            var wordsWithEmpty = sentance.Split(wordSplitter);
            var wordsValidated = FilterEmptyWords(wordsWithEmpty);
            return wordsValidated;
        }

        public static string[] FilterEmptyWords(string[] sentance)
        {
            var words = new List<string>();
           foreach (var word in sentance)
            {
                if (!String.IsNullOrWhiteSpace(word))
                {
                    words.Add(word);
                }
            }
            return words.ToArray();
        }
    }
}
