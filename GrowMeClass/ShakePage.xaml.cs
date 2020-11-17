using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;


using System.ComponentModel;
using System.Linq;
using System.Text;


namespace GrowMeClass
{
    public partial class ShakePage : ContentPage
    {
        public ShakePage()
        {
            InitializeComponent();

            //Creating TapGestureRecognizers    
            var tapImage = new TapGestureRecognizer();
            //Binding events    
            tapImage.Tapped += ShakeButton_Clicked;
            //Associating tap events to the image buttons    
            ShakeButton.GestureRecognizers.Add(tapImage);
            //void ShakeButton_Clicked(System.Object sender, System.EventArgs e)
            //{
            //    // handle the tap    
            //    DisplayAlert("Alert", "This is an image button", "OK");
            //}

        }

        //async void backButton1(System.Object sender, System.EventArgs e)
        //{
        //    await Navigation.PopAsync();

        //}


        async void ShakeButton_Clicked(System.Object sender, System.EventArgs e)
        {
            uint timeout = 50;

            await MyEntry.TranslateTo(-25, 0, timeout);

            await MyEntry.TranslateTo(25, 0, timeout);

            await MyEntry.TranslateTo(-20, 0, timeout);

            await MyEntry.TranslateTo(20, 0, timeout);

            await MyEntry.TranslateTo(-15, 0, timeout);

            await MyEntry.TranslateTo(15, 0, timeout);

            MyEntry.TranslationX = 0;

            await Task.Delay(2000);
            DisplayAlert("Alert", "You WON!!", "OK");
        }

        async void backButton1_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}


