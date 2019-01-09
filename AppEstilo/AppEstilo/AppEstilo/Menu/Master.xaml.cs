﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEstilo.Menu
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
            Detail = new NavigationPage(new Pagina.ImplicityStylePage());
            IsPresented = false;
        }

        private void GoPagina2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.ExplicityStylePage());
            IsPresented = false;
        }

        private void GoPagina3(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.GlobalStylePage());
            IsPresented = false;
        }

        private void GoPagina4(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.InheritStylePage());
            IsPresented = false;
        }

        private void GoPagina5(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.DynamicStylePage());
            IsPresented = false;
        }
    }
}