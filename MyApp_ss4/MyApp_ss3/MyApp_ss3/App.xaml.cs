using MyApp_ss3.Services;
using MyApp_ss3.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp_ss3
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
            // to show OtherPage and be able to go back
            //Navigation.PushAsync(new OtherPage());

            // to show AnotherPage and not have a Back button

            //MainPage = new NavigationPage(new SearchPeolebyCMND());
            // MainPage = new NavigationPage(new Search());

            MainPage = new NavigationPage(new LoginPage());
            //Navigation.PushModalAsync(new UserView());
            // to go back one step on the navigation stack
            //Navigation.PopAsync();
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
