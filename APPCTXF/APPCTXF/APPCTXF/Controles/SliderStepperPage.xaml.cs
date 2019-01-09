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
	public partial class SliderStepperPage : ContentPage
	{
		public SliderStepperPage ()
		{
			InitializeComponent ();
		}

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            SliderResult.Text = e.NewValue.ToString();
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            StepperResult.Text = e.NewValue.ToString();
        }
    }
}