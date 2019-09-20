using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectChange
{
	class Program
	{
		static void Main(string[] args)
		{
			List<DenominationInfo> denominations = new List<DenominationInfo>();

			denominations.Add(new DenominationInfo { Name = "Nickel", Amount = 0.05M });
			denominations.Add(new DenominationInfo { Name = "Quarter", Amount = 0.25M});
			denominations.Add(new DenominationInfo { Name = "Penny", Amount = 0.01M });
			denominations.Add(new DenominationInfo { Name = "Dime", Amount = 0.10M });
			denominations.Add(new DenominationInfo { Name = "Dollar", Amount = 1M });


			Console.Write("Please enter the amount owed: ");
			decimal amountOwed = decimal.Parse(Console.ReadLine());

			Console.Write("Please enter the amount paid: ");
			decimal amountPaid = decimal.Parse(Console.ReadLine());

			List<string> results = CalculateChange(amountOwed, amountPaid, denominations);

			foreach (string result in results)
			{
				Console.WriteLine(result);
			}

			Console.ReadLine();
		}

		private static List<string> CalculateChange(decimal amountOwed, decimal amountPaid, List<DenominationInfo> denominations)
		{
			List<string> output = new List<string>();
			decimal change = amountPaid - amountOwed;

			if (change < 0)
			{
				output.Add("You need to pay more.");
			}
			else if (change == 0)
			{
				output.Add("No change required");
			}
			else
			{
				var orderedDenominations = denominations.OrderByDescending(x => x.Amount);
				int count = 0;

				foreach (var denomination in orderedDenominations)
				{
					(change, count) = CalculateSpecificSchange(change, denomination.Amount);

					if (count > 0)
					{
						output.Add($"{count} {denomination.Name}");
					}
				}
			}

			return output;
		}

		//this is a tuple
		private static (decimal remainder, int numberOfItems) CalculateSpecificSchange(decimal amount, decimal denomination)
		{
			(decimal remainder, int numberOfItems) output = (0, 0);

			// 0.77 / 0.25 = 3.00825 - math.floor takes the 3 and puts into numberOfItems
			output.numberOfItems = (int)Math.Floor(amount / denomination);
			output.remainder = amount - (output.numberOfItems * denomination);

			return output;
		}
	}
}
