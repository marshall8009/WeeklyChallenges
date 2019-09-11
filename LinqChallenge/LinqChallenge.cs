using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqChallenge
{
    public class LinqChallenge
    {
        public static void LettersInOrder(string input)
        {
            var letters = from x in input
                          orderby x.ToString()
                          select x;

            foreach (var letter in letters)
            {
                Console.WriteLine(letter);
            }
        }

        public static void LettersInAnonymousObject(string input)
        {
            var letters = from x in input
                          group x by x.ToString().ToLower() into y
                          orderby y.Count() descending, y.Key.ToString()
                          select (new { Letter = y.Key, Count = y.Count() });

            foreach (var letter in letters)
            {
                Console.WriteLine($"Letter: { letter.Letter }, Count: { letter.Count }");
            }
        }
    }
}
