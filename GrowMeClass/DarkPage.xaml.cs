using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GrowMeClass
{
    public partial class DarkPage : ContentPage
    {
        public DarkPage()
        {
            InitializeComponent();
        }

        async void LightButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SleepPage());
        }

    }
}
