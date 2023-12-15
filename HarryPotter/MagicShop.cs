namespace HarryPotter
{
	internal class MagicShop
	{
		List<Pet> Pets { get; set; }
		List<Wand> Wands { get; set; }

		public MagicShop()
		{
			Pets = new List<Pet>();
			Wands = new List<Wand>();
		}

		public Item ShopDisplay()
		{
			Console.WriteLine("Welcome to Olivanders: Do you want to browse pets(p) or wands(w) ?");
			var input = Console.ReadLine();
			if (input == " p")
			{
				PrintPets();
				Console.WriteLine("What pet do you want to buy?");
				var petSelection = Console.ReadLine();
				return Pets[0];
			}
			else
			{
				PrintWands();
				Console.WriteLine("What pet do you want to buy?");
				var wandSelection = Console.ReadLine();
				return Wands[0];
			}
		}

		public void PrintPets()
		{
			int i = 0;
			foreach (var pet in Pets)
			{
				Console.WriteLine(pet.PetType + " " + i);
				i++;
			}
		}

		public void PrintWands()
		{
			foreach (var wand in Wands)
			{
				Console.WriteLine(wand.WandType);
			}
		}
	}
}