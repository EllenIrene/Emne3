using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimenOgEllen
{
	internal class Simen
	{
		public string Navn { get; set; }

		public int Alder { get; set; }

		public string Harfarge { get; set; }

		public string Hobby { get; set; }


		public Simen()
		{
			Navn = "Simen";
			Alder = 32;
			Harfarge = "Brunt";
			Hobby = "Musikk";
		}

		public void Introduksjon()
		{
			Console.WriteLine(
				$"Hei, jeg heter {Navn}, og er {Alder} år. \nJeg har {Harfarge} hår\nog liker å høre {Hobby} på fritiden");
		}

		public void Ekstra()
		{
			Console.Write("Nå sitter vi og programmerer som bare det.\nOg er egentlig ganske fornøyde \n");
		}

	}
}