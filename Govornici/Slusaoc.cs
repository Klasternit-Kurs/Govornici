using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Govornici
{
	public class Slusaoc : System.ComponentModel.INotifyPropertyChanged
	{
		public string Ime { get; set; }
		private string info;
		public string Info 
		{ 
			get => info; 
			set
			{
				info = value;
				PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs("Info"));
			}
		}

		public Slusaoc(string i) => Ime = i;

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		public override string ToString() => base.ToString();

	}
}
