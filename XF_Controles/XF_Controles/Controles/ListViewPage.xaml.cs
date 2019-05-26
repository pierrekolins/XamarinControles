using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_Controles.Modelo;

namespace XF_Controles.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();

            List <Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add( new Pessoa {Nome= "Marvin", Idade="300" });
            pessoas.Add(new Pessoa { Nome = "Arthur Dent", Idade = "35" });
            pessoas.Add(new Pessoa { Nome = "Ford Perfect", Idade = "50" });
            pessoas.Add(new Pessoa { Nome = "Tricia McMillan", Idade = "40" });
            ListaPessoa.ItemsSource = pessoas;
		}
	}
}