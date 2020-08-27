using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using MemberApp.ViewModels;
using System.Collections.Generic;
//using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

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

			NavigationPage navMemberManagePage = new NavigationPage(new MemberManagePage());
			navMemberManagePage.IconImageSource = "member.png";
			navMemberManagePage.Title = "會員管理";

			NavigationPage navEmployeeManagePage = new NavigationPage(new EmployeeManagePage());
			navEmployeeManagePage.IconImageSource = "friend.png";
			navEmployeeManagePage.Title = "員工管理";

			NavigationPage navPage1 = new NavigationPage(new Page1());
			navPage1.IconImageSource = "door.png";
			navPage1.Title = "離開";

			this.Children.Add(navHomePage);
			this.Children.Add(navMemberManagePage);
			this.Children.Add(navEmployeeManagePage);
			this.Children.Add(navPage1);

			On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom).SetBarItemColor(Color.Black).SetBarSelectedItemColor(Color.Blue);
			//On<iOS>().SetLargeTitleDisplay(LargeTitleDisplayMode.Never);
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