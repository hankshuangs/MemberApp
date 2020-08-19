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
        private List<Staff> _StaffList;
        private Staff _selectedStaf = new Staff();
        private List<Staff> _searchedStaff;
        private string _keyword;
        private bool _isBusy = false;
        private string _statusMessage;

        //取得會員資訊
        public List<Staff> StaffList
        {
            get
            {
                return _StaffList;
            }
            set
            {
                _StaffList = value;
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
                    StaffList = await staffServices.GetStaffAsync(_keyword);
                    IsBusy = false;
                });
            }
        }

        public string Keyword
        {
            get { return _keyword; }
            set
            {
                _keyword = value;
                OnPropertyChanged();
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
            InitializeDataAsync();
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
