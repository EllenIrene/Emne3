namespace HarryPotter
{
	internal class Wand : Item
	{
		public string WandType { get; set; }

		public Wand(string wandType) : base(wandType)
		{
			WandType = wandType;
		}
	}
}