﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GrowMeClass
{
    public partial class ToiletPage : ContentPage
    {
        public ToiletPage()
        {
            InitializeComponent();
        }

        async void MainButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}