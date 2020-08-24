using MemberApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MemberApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            EtyAccount.Text = Helpers.Settings.Account;
            EtyPassword.Text = Helpers.Settings.Password;
        }

        private void BtnLogin_OnClicked(object sender, EventArgs e)
        {
            MainViewModel  mainViewModel =  BindingContext as MainViewModel;
            mainViewModel.Navigation = Navigation;          
        }

        private void BtnClean_OnClicked(object sender, EventArgs e)
        {
            EtyAccount.Text = string.Empty;
            EtyPassword.Text = string.Empty;
            LblMsg.Text = string.Empty;
        }
    }
}