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
    }
}
