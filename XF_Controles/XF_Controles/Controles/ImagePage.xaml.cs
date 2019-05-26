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
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent ();

            Image imgSW = new Image();        

            // Mudança da pasta padrão do projeto Windows
            if(Device.RuntimePlatform == Device.UWP)
            {
                imgSW.Source = ImageSource.FromFile("Imagem/sw.jpg");
            }
            else
            {
                imgSW.Source = ImageSource.FromFile("sw.jpg");
            }
            Container.Children.Add(imgSW);
        }
	}
}