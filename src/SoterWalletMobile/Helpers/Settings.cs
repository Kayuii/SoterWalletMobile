﻿using Plugin.Settings;
using Plugin.Settings.Abstractions;
namespace SoterWalletMobile.Helpers
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

        private const string DeviceNameKey = "device_name";
        public static string DeviceName
        {
            get
            {
                return AppSettings.GetValueOrDefault(DeviceNameKey, string.Empty);
            }
            set
            {
                AppSettings.AddOrUpdateValue(DeviceNameKey, value);
            }
        }

    }
}