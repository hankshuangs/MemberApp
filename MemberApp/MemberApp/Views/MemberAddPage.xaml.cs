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
    public partial class MemberAddPage : ContentPage
    {
        public MemberAddPage()
        {
            InitializeComponent();
        }

        private async void BtnAddConfirm_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopAsync();
        }
    }
}