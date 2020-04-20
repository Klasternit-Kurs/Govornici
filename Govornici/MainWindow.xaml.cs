using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Govornici
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private string unos;
		public string Unos 
		{ 
			get => unos; 
			set 
			{
				unos = value;
				g.Govori(unos);
			}
		}

		private string unos2;
		public string Unos2
		{
			get => unos2;
			set
			{
				unos2 = value;
				g2.Govori(unos2);
			}
		}

		ObservableCollection<Slusaoc> lstSl = new ObservableCollection<Slusaoc>();
		Govornik g = new Govornik();
		Govornik g2 = new Govornik();

		public MainWindow()
		{
			InitializeComponent();
			DataContext = this;
			lstSl.Add(new Slusaoc("Pera"));
			lstSl.Add(new Slusaoc("Pera"));
			lstSl.Add(new Slusaoc("Pera"));
			lstSl.Add(new Slusaoc("Pera"));
			lstSl.Add(new Slusaoc("Pera"));
			dg.ItemsSource = lstSl;
		}

		private void CekiranG1(object sender, RoutedEventArgs e)
		{
			g.Slusaoci.Add((sender as Control).DataContext as Slusaoc);
		}

		private void OdcekiranoG1(object sender, RoutedEventArgs e)
		{
			g.Slusaoci.Remove((sender as Control).DataContext as Slusaoc);
		}

		private void CekiranG2(object sender, RoutedEventArgs e)
		{
			g2.Slusaoci.Add((sender as Control).DataContext as Slusaoc);
		}

		private void OdcekiranoG2(object sender, RoutedEventArgs e)
		{
			g2.Slusaoci.Remove((sender as Control).DataContext as Slusaoc);
		}
	}
}
