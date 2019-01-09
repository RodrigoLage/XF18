using AppCell.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCell.Pagina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome = "José", Cargo = "Presidente da Empresa" });
            Lista.Add(new Funcionario() { Nome = "Maria", Cargo = "Gerente de Vendas" });
            Lista.Add(new Funcionario() { Nome = "Elaine", Cargo = "Gerente de Marketing" });
            Lista.Add(new Funcionario() { Nome = "Felipe", Cargo = "Entregador" });
            Lista.Add(new Funcionario() { Nome = "João", Cargo = "Vendedor" });

            ListaFuncionario.ItemsSource = Lista;

        }

        private void ItemSelecionadoAction(object sender, SelectedItemChangedEventArgs e)
        {
            Funcionario func = (Funcionario)e.SelectedItem;

            Navigation.PushAsync(new Detalhe.DetailPage(func));

        }

        private void FeriasAction(object sender, EventArgs e)
        {
            MenuItem botao = (MenuItem)sender;
            Funcionario func = (Funcionario)botao.CommandParameter;

            DisplayAlert("Título: " + func.Nome, "Mensagem: " + func.Nome + " - " + func.Cargo, "OK");


        }
        
        private void AbonoAction(object sender, EventArgs e)
        {

        }


    }
}