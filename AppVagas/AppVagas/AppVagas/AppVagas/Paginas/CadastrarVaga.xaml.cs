using AppVagas.Modelos;
using AppVagas.Banco;
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
	public partial class CadastrarVaga : ContentPage
	{
		public CadastrarVaga ()
		{
			InitializeComponent ();
		}

        private void SalvarAction(object sender, EventArgs e)
        {
            //TODO - Validar Dados do Cadastro
            Vaga vaga = new Vaga();
            vaga.NomeVaga = NomeVaga.Text;
            vaga.Empresa = Empresa.Text;
            vaga.Quantidade = short.Parse(Quantidade.Text);
            vaga.Salario = double.Parse(Salario.Text);
            vaga.Cidade = Cidade.Text;
            vaga.Descricao = Descricao.Text;
            vaga.TipoContratacao = (TipoContratacao.IsToggled) ? "PJ" : "CLT";
            vaga.Telefone = Telefone.Text;
            vaga.Email = Email.Text;

            Database database = new Database();
            database.Cadastro(vaga);

            App.Current.MainPage = new NavigationPage(new ConsultarVagas());

        }
    }
}