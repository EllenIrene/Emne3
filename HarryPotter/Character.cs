namespace HarryPotter
{
	internal class Character
	{
		public string Name { get; set; }
		public string House { get; set; }

		public List<Pet> Pets { get; set; }
		public List<Wand> Wands { get; set; }

		public Character(string name, string house)
		{
			Name = name;
			House = house;
			Pets = new List<Pet>();
			Wands = new List<Wand>();

			// Legg til en pet
			Pets.Add(new Pet("Katte"));
		}

		public void AddPet(string petType)
		{
			Pets.Add(new Pet(petType));
		}

		public void LeaveHogwarts(MagicShop shop)
		{
			EnterMagicShop(shop);
		}

		public void LeaveStore()
		{

		}

		public void GoToHogwarts()
		{

		}

		public void Introduction()
		{
			Console.WriteLine($"Hi, my name is {Name}, i belong to {House} ");
			PrintPets();
		}

		private void PrintPets()
		{
			foreach (var pet in Pets)
			{
				Console.WriteLine("I have a " + pet.PetType);
			}
		}

		public void EnterMagicShop(MagicShop shop)
		{
			var item = shop.ShopDisplay();
			BuyItem(item);
		}

		public void BuyItem(Item item)
		{
			// Putt item i inventory
			LeaveStore();
		}

		public void PerformMagic()
		{

		}
	}
}
