public class TradingLogic
{
	static Random random = new Random();

	public static decimal GeneratePrice(Stock stock)
	{
		// Sjekk om stock er null
		if (stock == null)
		{
			Console.WriteLine("Stock is null.");
			return 0;
		}
		// Generer en ny pris basert på den gjeldende prisen
		decimal newPrice = stock.CurrentPrice + (decimal)(random.NextDouble() * 2 - 1);
		return newPrice;
	}

	public static void BuyStock(Portfolio portfolio, string name, int quantity)
	{
		// Hent gjeldende pris fra simulatoren
		Stock stock = portfolio.Stocks.FirstOrDefault(s => s.Name == name);
		if (stock == null)
		{
			Console.WriteLine("Stock does not exist in portfolio.");
			return;
		}
		decimal price = GeneratePrice(stock);
		// Oppdater antall aksjer brukeren eier
	}

	public static void SellStock(Portfolio portfolio, string name, int quantity)
	{
		// Hent gjeldende pris fra simulatoren
		Stock stock = portfolio.Stocks.FirstOrDefault(s => s.Name == name);
		if (stock == null)
		{
			Console.WriteLine("Stock does not exist in portfolio.");
			return;
		}
		decimal price = GeneratePrice(stock);
		// Oppdater antall aksjer brukeren eier
	}
}