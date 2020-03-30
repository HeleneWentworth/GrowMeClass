using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GrowMeClass
{
    public partial class PlayPage : ContentPage
    {
        public PlayPage()
        {
            InitializeComponent();
        }

        async void ToiletButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ToiletPage());
        }
    }
}
