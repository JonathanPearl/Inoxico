using System;
using System.Collections.Generic;

namespace Inoxico.TechnicalTest
{
    public class LongestSentance
    {
        public static int Solution(string phrase)
        {
            var sentances = PhraseIntoSentances(phrase);

            return 1;
        }

        public static IEnumerable<string> PhraseIntoSentances(string phrase)
        {

            var sentanceEndings = new char[] { '.', '!', '?' };
            var sentances = phrase.Split(sentanceEndings);
            return sentances;

        }

        public static IEnumerable<string> SentaceIntoWords(string sentance)
        {
            var wordSplitter = ' ';
            var words = sentance.Split(wordSplitter);
           
            return words;
        }

        public static IEnumerable<string> FilterEmptyWords(string[] sentance)
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
