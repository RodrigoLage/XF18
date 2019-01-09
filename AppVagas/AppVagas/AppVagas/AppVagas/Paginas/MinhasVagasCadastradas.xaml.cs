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
	public partial class MinhasVagasCadastradas : ContentPage
	{

        List<Vaga> Lista { get; set; }

        public MinhasVagasCadastradas ()
		{
            InitializeComponent();

            ConsultaVagas();
        }

        private void ConsultaVagas()
        {
            Database database = new Database();
            Lista = database.Consultar();
            ListaVagas.ItemsSource = Lista;

            lblCount.Text = Lista.Count.ToString() + " vagas encontradas";
        }

        private void EditarAction(object sender, EventArgs e)
        {
            Label lblEditar = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblEditar.GestureRecognizers[0];
            Vaga vaga = tapGest.CommandParameter as Vaga;

            Navigation.PushAsync(new EditarVaga(vaga));
        }

        private void ExcluirAction(object sender, EventArgs e)
        {
            Label lblExcluir = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblExcluir.GestureRecognizers[0];
            Vaga vaga = tapGest.CommandParameter as Vaga;

            Database database = new Database();
            database.Excluir(vaga);

            ConsultaVagas();

        }

        private void GoCadastro(object sender, EventArgs e)
        {

        }

        private void GoMinhasVagas(object sender, EventArgs e)
        {

        }

        private void PesquisarAction(object sender, TextChangedEventArgs e)
        {
            ConsultaVagas();
            ListaVagas.ItemsSource = Lista.Where(a => a.NomeVaga.Contains(e.NewTextValue)).ToList();
        }
    }
}