using System;

namespace TemperatureChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            ITemperature temperature = new Temperature();
            string[] words = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

            for (int i = 0; i < 100; i++)
            {
                temperature.Insert(rnd.Next(1, 101));
            }

            for (int i = 0; i < 100; i++)
            {
                temperature.Insert(words[rnd.Next(0, 10)]);
            }

            Console.WriteLine($"Min Temp: { temperature.MinTemperature }");
            Console.WriteLine($"Max Temp: { temperature.MaxTemperature }");
            Console.WriteLine($"Avg Temp: { temperature.AvgTemperature }");

            Console.ReadLine();
        }
    }
}
