using System;
using System.Text.RegularExpressions;

namespace Regex1
{
	class Program
	{
		static void Main(string[] args)
		{
			CheckString("This is the first/second check.");

			Console.Write("Press any key...");
			Console.ReadKey();
		}

		private static void CheckString(string input)
		{
			Console.WriteLine(ReplaceCharacters(input));
		}

		#region Replace all characters
		/// <summary>
		/// Replace the characters in Pattern to hyphen without loops.
		/// </summary>

		const string Pattern = @"([\s,.//\\-_=])+";

		private static readonly Regex regexCheck = new Regex(Pattern);

		public static string ReplaceCharacters(string input)
		{
			return regexCheck.Replace(input, "-"); ;
		}
		#endregion
	}
}
