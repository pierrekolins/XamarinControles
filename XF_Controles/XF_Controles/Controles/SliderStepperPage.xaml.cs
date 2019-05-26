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
	public partial class SliderStepperPage : ContentPage
	{
		public SliderStepperPage ()
		{
			InitializeComponent ();
		}

        private void ActionMudouSlider(object sender, ValueChangedEventArgs args)
        {
            lbSlider.Text = args.NewValue.ToString();
        }

        private void ActionMudouStepper(object sender, ValueChangedEventArgs args)
        {
            lbStepper.Text = args.NewValue.ToString();
        }        
    }
}