class Program
{
	static void Main(string[] args)
	{
		Portfolio portfolio = new Portfolio();

		while (true)
		{
			Console.WriteLine("1. Buy stock");
			Console.WriteLine("2. Sell stock");
			Console.WriteLine("3. Exit");
			Console.Write("Enter choice: ");
			int choice = int.Parse(Console.ReadLine());

			switch (choice)
			{
				case 1:
					Console.Write("Enter stock name: ");
					string name = Console.ReadLine();
					if (!portfolio.Stocks.Any(s => s.Name == name))
					{
						Console.WriteLine("Stock does not exist in portfolio.");
						continue;
					}
					Console.Write("Enter quantity: ");
					int quantity = int.Parse(Console.ReadLine());
					TradingLogic.BuyStock(portfolio, name, quantity);
					break;
				case 2:
					Console.Write("Enter stock name: ");
					name = Console.ReadLine();
					if (!portfolio.Stocks.Any(s => s.Name == name))
					{
						Console.WriteLine("Stock does not exist in portfolio.");
						continue;
					}
					Console.Write("Enter quantity: ");
					quantity = int.Parse(Console.ReadLine());
					TradingLogic.SellStock(portfolio, name, quantity);
					break;
				case 3:
					return;
			}
		}
	}
}