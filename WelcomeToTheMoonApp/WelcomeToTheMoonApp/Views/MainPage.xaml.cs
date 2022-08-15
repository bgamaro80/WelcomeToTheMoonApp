using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WelcomeToTheMoonApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void StartButton_Clicked(object sender, EventArgs e)
        {
            var scenarios = Scenarios.ScenarioGenerator.GetAllScenarios();

            var scenarioTitles = scenarios.Select(s => s.GetAdventureTitle());

            string action = await DisplayActionSheet("Seleccionar escenario:", "Cancel", null, scenarioTitles.ToArray());

            var selected = scenarios.FirstOrDefault(s => s.GetAdventureTitle() == action);

            if (selected != null)
            {
                var game = new GamePage();
                game.Scenario = selected;
                
                await Navigation.PushModalAsync(game);
            }
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
