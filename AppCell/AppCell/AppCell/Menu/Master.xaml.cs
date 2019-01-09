using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCell.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void GoPagina1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AppCell.Pagina.TextCellPage());
            IsPresented = false;
        }

        private void GoPagina2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AppCell.Pagina.ImageCellPage());
            IsPresented = false;
        }

        private void GoPagina3(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AppCell.Pagina.EntryCellPage());
            IsPresented = false;
        }

        private void GoPagina4(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AppCell.Pagina.SwitchCellPage());
            IsPresented = false;
        }

        private void GoPagina5(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AppCell.Pagina.ViewCellPage());
            IsPresented = false;
        }

        private void GoPagina6(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AppCell.Pagina.ListViewPage());
            IsPresented = false;
        }

        private void GoPagina7(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AppCell.Pagina.ListViewButtonPage());
            IsPresented = false;
        }
    }
}