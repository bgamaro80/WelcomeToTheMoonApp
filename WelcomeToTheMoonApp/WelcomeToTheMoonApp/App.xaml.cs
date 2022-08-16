using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using WelcomeToTheMoonApp.Views;

namespace WelcomeToTheMoonApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            var mainPage = new MainPage();
            //var mainPage = new GamePage() { ScenarioNumber = 5 };
            //var mainPage = new AstraGamePage();

            return new Microsoft.Maui.Controls.Window(mainPage) { Title = "Hola Moon" };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
