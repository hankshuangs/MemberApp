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
    public partial class EmployeeManagePage : ContentPage
    {
        public EmployeeManagePage()
        {
            InitializeComponent();
        }

        private async void BtnEmployeeAdd_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new EmployeeAddPage());
        }
    }
}