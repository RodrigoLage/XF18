using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APPCTXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebViewPage : ContentPage
	{
		public WebViewPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navegador.Source = EnderecoSite.Text;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (Navegador.CanGoForward)
            {
                Navegador.GoForward();
            }
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            if (Navegador.CanGoBack)
            {
                Navegador.GoBack();
            }
        }

        private void ActionCarregando(object sender, EventArgs e)
        {
            lblStatus.Text = "Carregando...";
        }

        private void ActionCarregado(object sender, EventArgs e)
        {
            lblStatus.Text = "Finalizado";
        }

        


    }
}