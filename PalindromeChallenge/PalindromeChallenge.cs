using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeChallenge
{
    public class PalindromeChallenge
    {
        public static void CheckForPalindrome(string str)
        {
            string isPalindrome = "";
            char[] strChar = str.ToCharArray();

            Array.Reverse(strChar);
            isPalindrome = new string(strChar);

            if (isPalindrome == str)
            {
                Console.WriteLine($"{ str } is a palindrome");
            }
            else
            {
                Console.WriteLine($"{ str } is not  palindrome.");
            }
        }

        public static void LinqPalindrome(string str)
        {
            str = str.ToLower();

            string oldStr = new string(str.Where(x => char.IsLetterOrDigit(x)).ToArray());
            string newStr = new string(str.Where(x => char.IsLetterOrDigit(x)).Reverse().ToArray());

            return newStr == oldStr;
        }
    }
}
