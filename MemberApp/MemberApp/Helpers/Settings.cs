using System;
using System.Collections.Generic;
using System.Text;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace MemberApp.Helpers
{
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants
        private static readonly string SettingsDefault = string.Empty;
        private const string SettingsKey = "settings_key";
        #endregion

        //測試
        public static string GeneralSettings
        {
            get
            {
                return AppSettings.GetValueOrDefault(SettingsKey, SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(SettingsKey, value);
            }
        }

        //帳號
        public static string Account
        {
            get
            {
                return AppSettings.GetValueOrDefault("Account", SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue("Account", value);
            }
        }
        //密碼
        public static string Password
        {
            get
            {
                return AppSettings.GetValueOrDefault("Password", SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue("Password", value);
            }
        }


    }
}
