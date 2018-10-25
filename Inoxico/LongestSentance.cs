using System;
using System.Collections.Generic;

namespace Inoxico.TechnicalTest
{
    public class LongestSentance
    {
        public static int Solution(string phrase)
        {


            return 1;
        }

        public static IEnumerable<string> SeperateIntoSentances(string phrase)
        {
            
            var sentanceEndings = new List<char>();
            sentanceEndings.Add('.');
            sentanceEndings.Add('!');
            sentanceEndings.Add('?');

            var sentances = phrase.Split(sentanceEndings.ToArray());
            return sentances;

        }
    }
}
