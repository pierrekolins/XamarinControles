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
	public partial class PickerPage : ContentPage
	{
		public PickerPage ()
		{
			InitializeComponent ();
		}

        private void MudarEmpresa(object sender, SelectedItemChangedEventArgs args)
        {
            Picker picker = (Picker)sender;
            lbSelecao.Text = "Index: "+picker.SelectedIndex.ToString() +" - Empresa: "+  picker.SelectedItem.ToString();
        }

    }
}