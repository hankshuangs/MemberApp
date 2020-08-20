using MemberApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MemberApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Helpers.Settings.Account = "10611515";
            //Helpers.Settings.Password = "333";
            MainPage = new NavigationPage(new LoginPage());
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
