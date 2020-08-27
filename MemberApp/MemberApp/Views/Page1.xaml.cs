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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void BtnGO_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Page2());
            //await this.Navigation.PushAsync
        }



    }
}