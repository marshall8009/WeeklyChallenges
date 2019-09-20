using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberChallenge
{
	class Program
	{
		static void Main(string[] args)
		{
			string cont = "";
			do
			{
				Console.Write("Enter a whole number to check for prime: ");
				string numToCheckText = Console.ReadLine();

				int numToCheck = int.Parse(numToCheckText);
				Dictionary<int, bool?> factors = PrimeNumber(numToCheck);

				if (factors.Count == 0)
				{
					Console.WriteLine($"{numToCheck} is prime.");
				}
				else
				{
					Console.WriteLine($"{numToCheck} is a composite number.");
					Console.WriteLine($"There are {factors.Count} factors in {numToCheck}");

					IEnumerable<int> primeFactors = from factor in factors
													where factor.Value == true
													select factor.Key;

					Console.WriteLine($"The largest prime factor is {primeFactors.Max()}");
					Console.WriteLine($"Here are all of the prime factors:");
					foreach (int factor in primeFactors)
					{
						Console.WriteLine(factor);
					}
				}

				Console.WriteLine();
				Console.Write("Do you want to continue (yes/no)");
				cont = Console.ReadLine();

			} while (cont.ToLower() == "yes");
		}

		private static Dictionary<int, bool?> PrimeNumber(int number)
		{
			//putting a ? after a data type lets you put null as a value
			Dictionary<int, bool?> output = new Dictionary<int, bool?>();

			int max = number / 2;
			for (int i = 2; i <= max; i++)
			{

				if (number % i == 0)
				{
					output.Add(i, null);
				}
			}

			if (output.Count > 0)
			{
				foreach (var factor in output.Keys.ToList())
				{
					if (PrimeNumber(factor).Count == 0)
					{
						output[factor] = true;
					}
					else
					{
						output[factor] = false;
					}
				}
			}

			return output;
		}
	}
}
