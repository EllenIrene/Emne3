using System;

class Program
{
	static void Main(string[] args)
	{
		while (true)
		{
			Console.WriteLine("1. RotateText");
			Console.WriteLine("2. Change word");
			Console.WriteLine("Enter number to select option:");
			var input = Console.ReadLine();

			switch (input)
			{
				case "1":
					Console.WriteLine("Enter a word to rotate:");
					var word = Console.ReadLine();
					Console.WriteLine(RotateText(word));
					break;
				case "2":
					Console.WriteLine("Enter a word to change:");
					var wordToChange = Console.ReadLine();
					Console.WriteLine(ChangeWord(wordToChange));
					break;
				default:
					Console.WriteLine("Invalid input. Please enter 1 or 2.");
					break;
			}
		}
	}

	static string RotateText(string text)
	{
		char[] charArray = text.ToCharArray();
		Array.Reverse(charArray);
		return new string(charArray);
	}

	static string ChangeWord(string text)
	{
		return text.Replace('e', 'a');
	}
}