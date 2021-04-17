using System;
using System.Text.RegularExpressions;

/* This example for used in JoostMantainence for collect the Opened articles.
 * 
 * Examples:
 * - Cornflakes, box => Cornflakes, box | empty
 * - Tissues [100 pcs] (living room), box => Tissues (living room), box | 100 pcs
 * 
 */
namespace RegEx4
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] items = { "Cornflakes, box", "Tissues [100 pcs] (living room), box" };

			foreach (string item in items)
			{
				var output = SplitArticle(item);
				if (output.Number != "")
					Console.WriteLine($"{item} => {output.Article} with {output.Number}");
				else
					Console.WriteLine($"{item} => {output.Article}");
			};

			Console.Write("\nPress any key...");
			Console.ReadKey();
		}

		static (string Article, string Number) SplitArticle(string input)
		{
			string number = "";
			Regex regex = new Regex(@".(?<Number>\[.+\])");

			Match match = regex.Match(input);
			string article = regex.Replace(input, "");

			if (match.Value != "")
			{
				regex = new Regex(@"\[|\]");
				number = regex.Replace(match.Value, "").Trim();
			}

			return (article, number);
		}
	}
}
