using System;
using WelcomeToTheMoonApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WelcomeToTheMoonApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            //MainPage = new GamePage() { ScenarioNumber = 5 };
            //MainPage = new AstraGamePage();
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
