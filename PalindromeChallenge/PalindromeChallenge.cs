using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
