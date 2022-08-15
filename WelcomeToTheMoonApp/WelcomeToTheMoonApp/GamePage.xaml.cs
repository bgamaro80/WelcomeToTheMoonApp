using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelcomeToTheMoonApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WelcomeToTheMoonApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GamePage : ContentPage
    {
        protected NormalGameViewModel mGameViewModel;

        public GamePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            mGameViewModel = new NormalGameViewModel();
            mGameViewModel.Init();
            BindingContext = mGameViewModel;
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        protected async void OnTapped(object sender, EventArgs e)
        {
            var gameOver = await DisplayAlert(null, "¿Finalizar partida?", "Finalizar", "Seguir jugando");

            if (gameOver)
                await Navigation.PopModalAsync();
        }

        protected volatile bool mOnNextRoundClick = false;

        protected async void NextRound_Click(object sender, EventArgs e)
        {
            if (mOnNextRoundClick)
                return;

            mOnNextRoundClick = true;

            try
            {
                mGameViewModel.NextTurn();

                await Task.Delay(250);
            }
            finally
            {
                mOnNextRoundClick = false;
            }
        }

        protected async void PreviousRound_Click(object sender, EventArgs e)
        {
            if (mOnNextRoundClick)
                return;

            mOnNextRoundClick = true;
         
            try
            {
                var confirm = await DisplayAlert("Ronda anterior", "¿Retroceder una ronda?", "Sí", "Seguir jugando");

                if (confirm)
                    mGameViewModel.PreviousTurn();

                await Task.Delay(250);
            }
            finally
            {
                mOnNextRoundClick = false;
            }
        }
    }
}