using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;




namespace GrowMeClass
{
    public partial class SleepPage : ContentPage
    {
        public SleepPage()
        {
            InitializeComponent();
        }


        async void PlayButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PlayPage());
        }

        async void MainButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }

        async void LightButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DarkPage());
        }
    }
}
