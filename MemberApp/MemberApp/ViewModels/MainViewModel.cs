using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MemberApp.Models;
using MemberApp.Services;

namespace MemberApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private List<Staff> _staffList;
        private string _account=string.Empty;
        private string _password = string.Empty;
        private bool _isBusy = false;
        private string _statusMessage = string.Empty;
        private INavigation _navigation;

        public INavigation Navigation
        {
            get
            {
                return _navigation;
            }
            set
            {
                _navigation = value;
                OnPropertyChanged();
            }
        }

        //取得會員資訊
        public List<Staff> StaffList
        {
            get
            {
                return _staffList;
            }
            set
            {
                _staffList = value;
                OnPropertyChanged();
            }
        }

        //帳號
        public string Account
        {
            get { return _account; }
            set
            {
                _account = value;
                OnPropertyChanged();
            }
        }

        //帳號
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        //會員登入取資訊
        public Command LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    IsBusy = true;
                    var staffServices = new StaffServices();
                    try
                    {
                        if (string.IsNullOrWhiteSpace(_account) || string.IsNullOrWhiteSpace(_password))
                        {
                            StatusMessage = "帳號或密碼未輸入";
                            IsBusy = false;
                            return;
                        }

                        StaffList = await staffServices.GetStaffAsync(_account, _password);
                        List<Staff> aa = StaffList;
                        if (StaffList.Count == 0)
                        {
                            StatusMessage = "帳號或密碼錯誤";
                            IsBusy = false;
                            return;
                        }
                    }
                    catch (Exception e)
                    {
                        StatusMessage = "無法連線伺服器\n"+ e.Message;
                    }
                    StatusMessage = "";
                    //登入成功
                    IsBusy = false;
                    Helpers.Settings.Account = _account;
                    Helpers.Settings.Password = _password;
                    await Navigation.PushAsync(new MainPage(this));
                });
            }
        }

        public string StatusMessage
        {
            get { return _statusMessage; }
            set
            {
                _statusMessage = value;
                OnPropertyChanged();
            }
        }

        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            //InitializeDataAsync();
        }
        private async void InitializeDataAsync()
        {
            IsBusy = true;
            var staffServices = new StaffServices();
            StaffList = await staffServices.GetStaffAsync();
            IsBusy = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
