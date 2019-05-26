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
	public partial class WebViewPage : ContentPage
	{
		public WebViewPage ()
		{
			InitializeComponent ();
		}

        private void GoSite(object sender, EventArgs args)
        {
            Navegador.Source = site.Text;
        }

        private void GoVoltar(object sender, EventArgs args)
        {
            if (Navegador.CanGoBack)
            {
                Navegador.GoBack();
            }
        }

        private void GoProximo(object sender, EventArgs args)
        {
            if (Navegador.CanGoForward)
            {
                Navegador.GoForward();
            }
        }

        private void ActionCarregando(object sender, EventArgs args)
        {
            lbStatus.Text = "Carregando...";
        }

        private void ActionCarregado(object sender, EventArgs args)
        {
            lbStatus.Text = "Concluído";
        }
    }
}