using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_Controles.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchBarPage : ContentPage
	{
        private List<string> times;

        public SearchBarPage ()
		{
			InitializeComponent ();

            times = new List<string>();
            times.Add("Cruzeiro");
            times.Add("Atlético");
            times.Add("Palmeiras");
            times.Add("São Paulo");
            times.Add("Santos");
            times.Add("Grêmio");
            times.Add("Flamengo");

            Preencher(times);

        }

        private void PesquisarButton(object sender, EventArgs args)
        {
            var resultado = times.Where(t => t.Contains(((SearchBar)sender).Text)).ToList<string>();
            Preencher(resultado);
        }

        private void Pesquisar(object sender, TextChangedEventArgs args)
        {
            var resultado = times.Where(t => t.Contains(args.NewTextValue)).ToList<string>();
            Preencher(resultado);
        }

        private void Preencher(List<string> times)
        {

            listResult.Children.Clear();
            foreach (var time in times)
            {
                listResult.Children.Add(new Label { Text = time.ToString() });
            }
        }
	}
}