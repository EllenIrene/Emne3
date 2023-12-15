namespace HarryPotter
{
	internal class Pet : Item
	{
		public string PetType { get; set; }

		public Pet(string petType) : base(petType)
		{
			PetType = petType;
		}
	}
}