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

namespace WelcomeToTheMoonApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GamePage : ContentPage
    {
        protected NormalGameViewModel mGameViewModel;

        public Scenarios.Scenario Scenario { get; set; }

        public GamePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            mGameViewModel = new NormalGameViewModel();
            mGameViewModel.Init(Scenario);
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

        protected async void OnTappedObjectiveA(object sender, EventArgs e)
        {
            await OnObjectiveTapped(mGameViewModel.ObjectiveA);
        }

        protected async void OnTappedObjectiveB(object sender, EventArgs e)
        {
            await OnObjectiveTapped(mGameViewModel.ObjectiveB);
        }

        protected async void OnTappedObjectiveC(object sender, EventArgs e)
        {
            await OnObjectiveTapped(mGameViewModel.ObjectiveC);
        }

        protected async Task OnObjectiveTapped(Cards.ObjectiveCard objectiveCard)
        {
            var completar = objectiveCard.IsAccomplished ? "¿Deshacer objetivo?" : "¿Completar objetivo?";
            var action = objectiveCard.IsAccomplished ? "Deshacer" : "Completar";

            var accomplish = await DisplayAlert(objectiveCard.Text, completar, action, "Seguir jugando");

            if (accomplish)
            {
                mGameViewModel.AccomplishObjective(objectiveCard);

                if(mGameViewModel.AllObjectiveAccomplished())
                    await DisplayAlert(null, "Se han cumplido todos los objetivos, posible fin de partida.", "Ok");
            }
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