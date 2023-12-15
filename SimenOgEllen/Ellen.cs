using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimenOgEllen
{
	public class Ellen
	{
		public string Navn { get; set; }

		public int Alder { get; set; }

		public string Harfarge { get; set; }

		public string Hobby { get; set; }


		public Ellen()
		{
			Navn = "Ellen";
			Alder = 50;
			Harfarge = "Brunt";
			Hobby = "Klatre";
		}

		public void Introduksjon()
		{
			Console.WriteLine(
				$"Hei, jeg heter {Navn}, og er {Alder} år.\nJeg har {Harfarge} hår\nog liker å {Hobby} på fritiden");
		}
		public void Ekstra()
		{
			Console.Write("Vi har vært veldig effetive.\n");

		}

	}
}