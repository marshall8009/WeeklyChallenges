using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace SearchingForDataApp
{
	public partial class Dashboard : Form
	{
		BindingList<string> matchedLines = new BindingList<string>();
		List<string> lines = File.ReadAllLines(@"C:\Users\Jake\Documents\primary.txt").ToList();

		public Dashboard()
		{
			InitializeComponent();

			resultsListBox.DataSource = matchedLines;
		}

		private void searchTextButton_Click(object sender, EventArgs e)
		{
			
			matchedLines.Clear();

			foreach (var line in lines)
			{
				// line.Contains(textToSearchText.Text)
				if (line.IndexOf(textToSearchText.Text, StringComparison.OrdinalIgnoreCase) >= 0)
				{
					matchedLines.Add(line);
				}
			}
		}

		// searches for phone numbers in a file using a regex
		private void searchForPhoneNumberBtn_Click(object sender, EventArgs e)
		{
			string lines = File.ReadAllText(@"C:\Users\Jake\Documents\bonus.txt");
			matchedLines.Clear();

			// (###) ###-####
			Regex regex = new Regex(@" \(([0-9]{3})\) ([0-9]{3})-([0-9]{4}) ");
			MatchCollection matches = regex.Matches(lines);

			foreach (Match match in matches)
			{
				if (!string.IsNullOrWhiteSpace(match.Groups[0].Value))
				{
					matchedLines.Add(match.Groups[0].Value.Trim());
				}
			}
		}

		// dynamically searches as you type
		private void textToSearchText_TextChanged(object sender, EventArgs e)
		{
			if (textToSearchText.Text.Length < 2)
			{
				return;
			}

			searchTextButton_Click(sender, e);
		}
	}
}
