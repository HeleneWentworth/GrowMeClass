using System;
using System.Collections.Generic;
using Xamarin.Forms;
using GrowMeClass.Objects;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;








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

