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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
		public string DisplayName
		{
			get;
			set;
		}
		public string IconName
		{
			get;
			set;
		}
		public string DisplayTitle
		{
			get;
			set;
		}

    }
}