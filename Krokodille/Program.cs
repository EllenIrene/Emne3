class Program
{
	static void Main(string[] args)
	{
		Random rand = new Random();
		int score = 0;
		string userInput;

		while (true)
		{
			do
			{
				Console.WriteLine("Please enter <, =, or >:");
				userInput = Console.ReadLine();
			} while (userInput != "<" && userInput != "=" && userInput != ">");

			int num1 = rand.Next(1, 12);
			int num2 = rand.Next(1, 12);

			switch (userInput)
			{
				case "<":
					if (num1 < num2)
					{
						score++;
						Console.WriteLine("Correct!");
					}
					else
					{
						score--;
						Console.WriteLine("Incorrect!");
					}
					break;
				case ">":
					if (num1 > num2)
					{
						score++;
						Console.WriteLine("Correct!");
					}
					else
					{
						score--;
						Console.WriteLine("Incorrect!");
					}
					break;
				case "=":
					if (num1 == num2)
					{
						score++;
						Console.WriteLine("Correct!");
					}
					else
					{
						score--;
						Console.WriteLine("Incorrect!");
					}
					break;
				default:
					Console.WriteLine("Ugyldig input. Avslutter spill.");
					return;
			}

			Console.WriteLine($"Poengsum: {score}");
			Console.WriteLine($"Tilfeldige tall: {num1} _ {num2}");
		}
	}
}