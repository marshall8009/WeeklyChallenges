using System;

namespace LinqChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqChallenge.LettersInOrder("Hello World");
            Console.WriteLine();
            LinqChallenge.LettersInAnonymousObject("Last Hello World");

            Console.ReadLine();
        }
    }
}
