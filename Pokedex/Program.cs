using System.Net.Security;
using static System.Console;

namespace Pokedex
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var pikachu = new Pokemon("Pikachu", 10,30, "Sage");
			var bulbasaur = new Pokemon("Bulbasaur", 50, 2, "Hamre");

			WriteLine($"Du har funnet  {bulbasaur.Name} med Level: {bulbasaur.Level} med Power som: {bulbasaur.Power}\n og \n{pikachu.Name} med Level: {pikachu.Level} med Power:  {pikachu.Power}");
			


		}
	}
}
