using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringReplacemnetChallenege
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrimaryStringReplacement();
            BonusStringReplacement();

            Console.ReadLine();
        }

        private static void PrimaryStringReplacement()
        {
            List<string> primaryLines = File.ReadAllLines(@"C:\data\challengestxt\StringReplacement\primary.txt").ToList();

            Console.Write("Please enter the text to replace: ");
            string toReplace = Console.ReadLine();

            Console.Write("Please enter the replacement text: ");

            string replacementText = Console.ReadLine();

            for (int i = 0; i < primaryLines.Count; i++)
            {
                primaryLines[i] = primaryLines[i].Replace(toReplace, replacementText);
            }

            File.WriteAllLines(@"C:\data\challengestxt\StringReplacement\primaryReplacementLines.txt", primaryLines);

            Console.WriteLine("The text file has been saved");
        }

        private static void BonusStringReplacement()
        {
            string bonusLines = File.ReadAllText(@"C:\data\challengestxt\StringReplacement\bonus.txt");
            Dictionary<string, string> replacements = new Dictionary<string, string>();

            // Looking for literal open { brace
            // inside square brackets is one statement
            // look for something that does not have {} inside it
            // + means one or more
            var results = Regex.Matches(bonusLines, @"{[^{}]+}")
                .Cast<Match>()
                .Select(x => x.Value.Substring(1, x.Value.Length - 2))
                .ToHashSet(); // hashset cannot contain duplicates

            foreach (var result in results)
            {
                Console.Write($"Please enter a value for { result }: ");
                //replacements.Add(result, Console.ReadLine());
                bonusLines = bonusLines.Replace("{" + result + "}", Console.ReadLine());
            }

            //foreach (var item in replacements)
            //{
            //    bonusLines = bonusLines.Replace("{" + item.Key + "}", item.Value);
            //}

            File.WriteAllText(@"C:\data\challengestxt\StringReplacement\bonusReplacementLines.txt", bonusLines);
            Console.WriteLine("The text file has been saved");
        }
    }
}
