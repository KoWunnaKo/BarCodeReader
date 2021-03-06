﻿using BarCodeReader.ViewModels.Base;
using BarCodeReader.Views;
using System.Threading.Tasks;
using BarCodeReader.Services.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BarCodeReader
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            InitApp();

            if(Device.RuntimePlatform == Device.UWP)
            {
                InitNavigation();
            }
            MainPage = new CustomNavigationView(new MainMenuView());
        }

        private Task InitNavigation()
        {
            var navigationService = ViewModelLocator.Resolve<INavigationService>();
            return navigationService.InitializeAsync();
        }
        private void InitApp()
        {
            ViewModelLocator.RegisterDependencies(false);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
