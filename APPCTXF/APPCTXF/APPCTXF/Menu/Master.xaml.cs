using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APPCTXF.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

		public void GoActivityIndicatorPage(object sender, EventArgs args)
		{
			Detail = new NavigationPage( new Controles.ActivityIndicatorPage());
            IsPresented = false;
		}

		public void GoProgressBarPage(object sender, EventArgs args)
		{
			Detail = new NavigationPage(new Controles.ProgressBarPage());
            IsPresented = false;
        }

		public void GoBoxViewPage(object sender, EventArgs args)
		{
			Detail = new NavigationPage(new Controles.BoxViewPage());
            IsPresented = false;
        }

		public void GoLabelPage(object sender, EventArgs args)
		{
			Detail = new NavigationPage(new Controles.LabelPage());
            IsPresented = false;
        }

		public void GoButtonPage(object sender, EventArgs args)
		{
			Detail = new NavigationPage(new Controles.ButtonPage());
            IsPresented = false;
        }

		public void GoEntryEditorPage(object sender, EventArgs args)
		{
			Detail = new NavigationPage(new Controles.EntryEditorPage());
            IsPresented = false;
        }

		public void GoDatePickerPage(object sender, EventArgs args)
		{
			Detail = new NavigationPage(new Controles.DatePickerPage());
            IsPresented = false;
        }

		public void GoTimePickerPage(object sender, EventArgs args)
		{
			Detail = new NavigationPage(new Controles.TimePickerPage());
            IsPresented = false;
        }

		public void GoPickerPage(object sender, EventArgs args)
		{
			Detail = new NavigationPage(new Controles.PickerPage());
            IsPresented = false;
        }

        public void GoSearchBarPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.SearchBarPage());
            IsPresented = false;
        }

        public void GoSliderStepperPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.SliderStepperPage());
            IsPresented = false;
        }

        public void GoSwitchPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.SwitchPage());
            IsPresented = false;
        }

        public void GoImagePage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.ImagePage());
            IsPresented = false;
        }

        public void GoListViewPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.ListViewPage());
            IsPresented = false;
        }

        public void GoTableViewPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.TableViewPage());
            IsPresented = false;
        }

        public void GoWebViewPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.WebViewPage());
            IsPresented = false;
        }
        
    }
}