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
	public partial class Municipios : ContentPage
	{
        private List<Municipio> ListaInternaMunicipio { get; set; }
        private List<Municipio> ListaFiltradaMunicipio { get; set; }
        
        public Municipios (Estado estado)
		{
			InitializeComponent ();

            ListaInternaMunicipio = Servico.Servico.GetMunicipio(estado.id);
            ListaMunicipios.ItemsSource = ListaInternaMunicipio;

        }

        private void BuscaRapida(object sender, TextChangedEventArgs e)
        {
            ListaFiltradaMunicipio=  ListaInternaMunicipio.Where(a => a.nome.Contains(e.NewTextValue)).ToList();
            ListaMunicipios.ItemsSource = ListaFiltradaMunicipio;
        }
    }
}