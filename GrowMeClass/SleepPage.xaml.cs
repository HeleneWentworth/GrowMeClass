using System;
using System.Collections.Generic;

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
    }
}
