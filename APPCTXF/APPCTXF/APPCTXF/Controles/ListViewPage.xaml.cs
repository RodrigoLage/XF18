using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using APPCTXF.Modelo;

namespace APPCTXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();

            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(new Pessoa { Nome = "José", Idade = "20" });
            lista.Add(new Pessoa { Nome = "Felipe", Idade = "21" });
            lista.Add(new Pessoa { Nome = "Maria", Idade = "19" });
            lista.Add(new Pessoa { Nome = "Pedro", Idade = "35" });
            lista.Add(new Pessoa { Nome = "Paulo", Idade = "25" });
            lista.Add(new Pessoa { Nome = "Antonio", Idade = "22" });
            lista.Add(new Pessoa { Nome = "Barbara", Idade = "35" });
            lista.Add(new Pessoa { Nome = "Natalia", Idade = "22" });

            ListaPessoas.ItemsSource = lista;


		}
	}
}