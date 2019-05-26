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
	public partial class SwitchPage : ContentPage
	{
		public SwitchPage ()
		{
			InitializeComponent ();
		}

        private void ActionToggledSwitch(object sender, ToggledEventArgs args)
        {
            lbSwitch.Text = args.Value.ToString(); 
        }

    }
}