using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APP02.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : MasterDetailPage
	{
		public Menu ()
		{
			InitializeComponent ();
		}

		private void GoPaginaPerfil1(object sender, EventArgs args)
		{
			try
			{
				Detail = new NavigationPage(new Pages.Perfil1());
				IsPresented = false;
			}
			catch
			{ };
			
		}

		private void GoPaginaXamarin(object sender, EventArgs args)
		{
			try
			{
				Detail = new NavigationPage(new Pages.Xamarin());
				IsPresented = false;
			}
			catch
			{ };
		}

	}
}