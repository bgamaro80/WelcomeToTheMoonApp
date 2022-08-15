using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WelcomeToTheMoonApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void StartButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new GamePage());
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
