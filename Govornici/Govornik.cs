using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Govornici
{
	class Govornik
	{
		public List<Slusaoc> Slusaoci { get; set; } = new List<Slusaoc>();

		public void Govori(string g)
		{
			Slusaoci.ForEach(slus => slus.Info = g);

			//int broj = 0;
			//Slusaoci.ForEach(s => broj++);

			//foreach (Slusaoc s in Slusaoci)
			//{
			//	s.Info = g;
			//}
		}
	}
}
