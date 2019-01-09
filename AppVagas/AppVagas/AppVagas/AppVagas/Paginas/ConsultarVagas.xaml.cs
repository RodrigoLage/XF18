using AppVagas.Banco;
using AppVagas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppVagas.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConsultarVagas : ContentPage
	{

        List<Vaga> Lista { get; set; }

		public ConsultarVagas ()
		{
			InitializeComponent ();

            ConsultaVagas();
        }

        private void ConsultaVagas()
        {
            Database database = new Database();
            Lista = database.Consultar();
            ListaVagas.ItemsSource = Lista;

            lblCount.Text = Lista.Count.ToString() + " vagas encontradas";
        }

        private void GoCadastro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastrarVaga());
        }

        private void GoMinhasVagas(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MinhasVagasCadastradas());
        }

        private void MaisDetalheAction(object sender, EventArgs e)
        {
            Label lblDetalhe = (Label)sender;

            Vaga vaga = (Vaga)((TapGestureRecognizer)lblDetalhe.GestureRecognizers[0]).CommandParameter;

            Navigation.PushAsync(new DetalharVaga(vaga));
        }

        private void PesquisarAction(object sender, TextChangedEventArgs e)
        {
            ConsultaVagas();
            ListaVagas.ItemsSource = Lista.Where(a => a.NomeVaga.Contains(e.NewTextValue)).ToList();
        }
    }
}