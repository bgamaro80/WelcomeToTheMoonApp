using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Android.Views;
using AndroidX.Core.View;
using Microsoft.Maui.Controls;

namespace WelcomeToTheMoonApp.Droid
{
    [Activity(Label = "WelcomeToTheMoonApp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, 
        ConfigurationChanges = ConfigChanges.ScreenSize | 
                               ConfigChanges.Orientation | 
                               ConfigChanges.UiMode | 
                               ConfigChanges.ScreenLayout, 
        ScreenOrientation = ScreenOrientation.Landscape)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            HideSystemUI();

            SupportActionBar.Hide();
        }

        private void HideSystemUI()
        {
            this.Window.SetDecorFitsSystemWindows(false);

            var controller = new WindowInsetsControllerCompat(Window, Window.DecorView);
            controller.Hide(WindowInsetsCompat.Type.NavigationBars());
            controller.SystemBarsBehavior = WindowInsetsControllerCompat.BehaviorShowTransientBarsBySwipe;
        }
    }
}