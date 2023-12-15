public class Stock
{
	public string Name { get; set; }
	public decimal CurrentPrice { get; set; } = 0; // Sett en standardverdi for CurrentPrice
	public int Quantity { get; set; }
}