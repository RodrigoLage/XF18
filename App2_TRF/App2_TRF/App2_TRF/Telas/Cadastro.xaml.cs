using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App2_TRF.Modelos;

namespace App2_TRF.Telas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cadastro : ContentPage
	{

        private Byte Prioridade { get; set; }

        public Cadastro ()
		{
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            bool ErroExitste = false;

            if (!(txtNome.Text.Trim().Length > 0))
            {
                ErroExitste = true;
                DisplayAlert("ERRO", "Nome não preenchido!", "OK");
            }

            if (!(this.Prioridade > 0))
            {
                ErroExitste = true;
                DisplayAlert("ERRO", "Prioridade não foi informada!", "OK");
            }

            if (ErroExitste == false)
            {
                Tarefa tarefa = new Tarefa();
                tarefa.Nome = txtNome.Text;
                tarefa.Prioridade = this.Prioridade;

                new GerenciadorTarefa().Salvar(tarefa);

                App.Current.MainPage = new NavigationPage(new Inicio());
            }
            
        }

        public void PrioridadeSelectAction(object sender, EventArgs args)
        {
            var Stacks = slPrioridades.Children;

            foreach (var Linha in Stacks)
            {

                Label lblPrioridade = ((StackLayout)Linha).Children[1] as Label;
                lblPrioridade.TextColor = Color.Gray;

            }

            ((Label)((StackLayout)sender).Children[1]).TextColor = Color.Black;

            FileImageSource Source = ((Image)((StackLayout)sender).Children[0]).Source as FileImageSource;

            String Prioridade = Source.File.ToString().Replace("Resources/", "").Replace(".png", "").Replace("p", "");

            this.Prioridade = byte.Parse(Prioridade);

        }

    }
}