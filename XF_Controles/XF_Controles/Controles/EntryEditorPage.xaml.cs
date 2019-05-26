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
	public partial class EntryEditorPage : ContentPage
	{
		public EntryEditorPage ()
		{
			InitializeComponent ();

            txtIdade.TextChanged  += delegate (object sender, TextChangedEventArgs args)
            {
                lbIdade.Text = args.NewTextValue;
            };

            txtComentario.Completed += delegate (object sender, EventArgs args) 
            {
                lbComentario.Text = txtComentario.Text.Length.ToString();
            };
		}
	}
}