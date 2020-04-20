using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Govornici
{
	public class Diktafon
	{
		public List<string> SveReceno { get; set; } = new List<string>();

		public void Snimi(string s)
		{
			SveReceno.Add(s);
		}
	}
}
