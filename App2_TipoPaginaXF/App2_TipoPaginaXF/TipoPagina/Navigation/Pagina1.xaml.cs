using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_TipoPaginaXF.TipoPagina.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina1 : ContentPage
	{
		public Pagina1 ()
		{
			InitializeComponent ();
		}

        protected void MudarParaPagina2(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Pagina2());
        }

        protected void ChamarModal(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Navigation.Modal());
        }

        protected void ChamarMaster(object sender, EventArgs args)
        {
            App.Current.MainPage = new Master.Master();
        }
        

    }
}