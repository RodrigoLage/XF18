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
	public partial class SearchBarPage : ContentPage
	{
        private List<string> EmpresasTI;

        public SearchBarPage ()
		{
			InitializeComponent ();

            EmpresasTI = new List<string>();
            EmpresasTI.Add("Microsoft");
            EmpresasTI.Add("Oracle");
            EmpresasTI.Add("Google");
            EmpresasTI.Add("Apple");
            EmpresasTI.Add("IBM");
            EmpresasTI.Add("SAP");
            EmpresasTI.Add("Uber");
            EmpresasTI.Add("99Taxi");

            Preencher(EmpresasTI);

        }

        private void Preencher(List<string> _empresasTI)
        {
            ListResult.Children.Clear();
            foreach (var emp in _empresasTI)
            {
                ListResult.Children.Add(new Label { Text = emp });
            }
        }

        private void Pesquisar(object sender, TextChangedEventArgs args)
        {
            var Resultado = EmpresasTI.Where(a => a.Contains(args.NewTextValue)).ToList<string>();

            Preencher(Resultado);

        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs args)
        {

            var Resultado = EmpresasTI.Where(a => a.Contains(((SearchBar)sender).Text)).ToList<string>();

            Preencher(Resultado);

        }
    }
}