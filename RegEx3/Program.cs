using System;
using System.Text.RegularExpressions;

namespace Regex3
{
	class Program
  {
    static void Main(string[] args)
    {

      string Pattern = @"\s+\d{3}$";
      Regex regexCheck = new Regex(Pattern);
      string input = "full tally 020";

      Console.WriteLine($"Original: '{input}' => '{regexCheck.Replace(input, "")}'");

      Console.Write("\nPress any key...");
      Console.ReadKey();

    }
  }
}
