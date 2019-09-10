using System;

namespace PalindromeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            PalindromeChallenge.CheckForPalindrome("racecar");

            Console.WriteLine(PalindromeChallenge.LinqPalindrome("A man, a plan, a canal: Panama"));
            Console.WriteLine(PalindromeChallenge.LinqPalindrome("9.11.19"));

            Console.ReadLine();
        }
    }
}
