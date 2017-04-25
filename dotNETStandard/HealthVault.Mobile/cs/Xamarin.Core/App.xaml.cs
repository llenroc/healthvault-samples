﻿using System.Security.Cryptography;
using HealthVault.Sample.Xamarin.Core.Services;
using HealthVault.Sample.Xamarin.Core.ViewModels;
using HealthVault.Sample.Xamarin.Core.Views;
using Microsoft.HealthVault.Client;
using Xamarin.Forms;

namespace HealthVault.Sample.Xamarin.Core
{
    public partial class App : Application
    {
        public App(
            IHealthVaultSodaConnection connection, 
            IPlatformResourceProvider resourceProvider)
        {
            InitializeComponent();

            var navigationService = new NavigationService();
            var mainPage = new MainPage()
            {
                BindingContext = new MainPageViewModel(connection, navigationService, resourceProvider),
            };

            var navigationPage = new NavigationPage(mainPage);
            MainPage = navigationPage;
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
