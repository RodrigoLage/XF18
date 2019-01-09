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
	public partial class EditarVaga : ContentPage
	{

        private Vaga vaga { get; set; }

        public EditarVaga (Vaga vaga)
		{
			InitializeComponent ();
            this.vaga = vaga;
            //TODO - Preenchimento dos dados na tela

            NomeVaga.Text = vaga.NomeVaga;
            Empresa.Text = vaga.Empresa;
            Quantidade.Text = vaga.Quantidade.ToString();
            Salario.Text = vaga.Salario.ToString();
            Cidade.Text = vaga.Cidade;
            Descricao.Text = vaga.Descricao;
            TipoContratacao.IsToggled = (vaga.TipoContratacao == "CLT") ? false : true;
            Telefone.Text = vaga.Telefone;
            Email.Text = vaga.Email;

            

        }

        private void SalvarAction(object sender, EventArgs e)
        {
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
            database.Atualizar(vaga);

            App.Current.MainPage = new NavigationPage(new MinhasVagasCadastradas());
            
        }
    }
}