using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;
using System.Linq;
using System.Text;




namespace GrowMeClass
{
    public partial class SleepPage : ContentPage
    {
        public SleepPage()
        {
            InitializeComponent();
        }


        async void backButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        async void LightButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DarkPage());
        }

        
    }
}
