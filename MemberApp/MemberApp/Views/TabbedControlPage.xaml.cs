using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using MemberApp.ViewModels;
using System.Collections.Generic;

namespace MemberApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyTabbedPage : Xamarin.Forms.TabbedPage
    {
        public MyTabbedPage(MainViewModel mainViewModel)
        {
            InitializeComponent();
            BindingContext = mainViewModel;

			NavigationPage navHomePage = new NavigationPage(new HomePage());
			navHomePage.IconImageSource = "home.png";
			navHomePage.Title = "首頁";

			NavigationPage navNewMemberPage = new NavigationPage(new NewMemberPage());
			navNewMemberPage.IconImageSource = "friend.png";
			navNewMemberPage.Title = "新增";

			NavigationPage navPage1 = new NavigationPage(new Page1());
			navPage1.IconImageSource = "door.png";
			navPage1.Title = "離開";

			this.Children.Add(navHomePage);
			this.Children.Add(navNewMemberPage);
			this.Children.Add(navPage1);

			On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom).SetBarItemColor(Color.Black).SetBarSelectedItemColor(Color.Blue);

		}
    }

	//範例Page上設定屬性值
	public class MyPage
	{

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