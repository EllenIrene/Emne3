using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
	internal class Pokemon
	{
		public string Name;
		public int Level;
		public int Health;
		public string Power;

		public Pokemon(string name, int level, int health, string power)
		{
			Name = name;
			Level = level;
			Health = health;
			Power = power;
		}
	}
	
}
