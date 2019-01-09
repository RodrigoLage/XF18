using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppListaBrasil.Modelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppListaBrasil
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Estados : ContentPage
	{
		public Estados ()
		{
			InitializeComponent ();

            ListaEstados.ItemsSource = Servico.Servico.GetEstados();

		}

        private void SelecaoEstadoAction(object sender, SelectedItemChangedEventArgs e)
        {
            Estado estado = (Estado)e.SelectedItem;

            Navigation.PushAsync(new Municipios(estado));
        }
    }
}