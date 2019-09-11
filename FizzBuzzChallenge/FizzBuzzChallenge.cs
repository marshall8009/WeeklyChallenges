using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzChallenge
{
    public class FizzBuzzChallenge
    {
        public static string Fizzbuzz(int number)
        {
            string output = "";
            for (int i = 1; i <= number; i++)
            {
                bool isFizz = (i % 3 == 0);
                bool isBuzz = (i % 5 == 0);

                if (isFizz && isBuzz)
                {
                    output += $"FizzBuzz {i}\n";
                }
                else if (isBuzz)
                {
                    output += $"Buzz {i}\n";
                }
                else if (isFizz)
                {
                    output += $"Fizz {i}\n";
                }
                else
                {
                    output += $"{i}\n";
                }
            }

            return output;
        }
    }
}
