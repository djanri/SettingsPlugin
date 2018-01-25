// Helpers/Settings.cs
using Plugin.Settings.Abstractions;
using System;

namespace Plugin.Settings.Tests.Portable.Helpers
{
    /// <summary>
    /// This is the Settings static class that can be used in your Core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters. 
    /// </summary>
    public static class TestSettings
    {
        public static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        public static string FileName { get; set; } = null;

        #region Setting Constants

        public const string SettingsKey = "settings_key";
        private static readonly string SettingsDefault = string.Empty;

        #endregion

        public static Guid GuidSetting
        {
            get
            {
                return AppSettings.GetValueOrDefault("guid_setting", Guid.Empty, FileName);
            }
            set
            {
                //if value has changed then save it!
                AppSettings.AddOrUpdateValue("guid_setting", value, FileName);
            }
        }

        public static decimal DecimalSetting
        {
            get
            {
                return AppSettings.GetValueOrDefault("decimal_setting", (decimal)0, FileName);
            }
            set
            {
                //if value has changed then save it!
                AppSettings.AddOrUpdateValue("decimal_setting", value, FileName);
            }
        }

        public static int IntSetting
        {
            get
            {
                return AppSettings.GetValueOrDefault("int_setting", (int)0, FileName);
            }
            set
            {
                //if value has changed then save it!
                AppSettings.AddOrUpdateValue("int_setting", value, FileName);
            }
        }

        public static float FloatSetting
        {
            get
            {
                return AppSettings.GetValueOrDefault("float_setting", (float)0, FileName);
            }
            set
            {
                //if value has changed then save it!
                AppSettings.AddOrUpdateValue("float_setting", value, FileName);
            }
        }

        public static Int64 Int64Setting
        {
            get
            {
                return AppSettings.GetValueOrDefault("int64_setting", (Int64)0, FileName);
            }
            set
            {
                //if value has changed then save it!
                AppSettings.AddOrUpdateValue("int64_setting", value, FileName);
            }
        }

        public static Int32 Int32Setting
        {
            get
            {
                return AppSettings.GetValueOrDefault("int32_setting", (Int32)0, FileName);
            }
            set
            {
                //if value has changed then save it!
                AppSettings.AddOrUpdateValue("int32_setting", value, FileName);
            }
        }

        public static DateTime DateTimeSetting
        {
            get
            {
                return AppSettings.GetValueOrDefault("date_setting", DateTime.Now, FileName);
            }
            set
            {
                //if value has changed then save it!
                AppSettings.AddOrUpdateValue("date_setting", value, FileName);
            }
        }

        public static double DoubleSetting
        {
            get
            {
                return AppSettings.GetValueOrDefault("double_setting", (double)0, FileName);
            }
            set
            {
                //if value has changed then save it!
                AppSettings.AddOrUpdateValue("double_setting", value, FileName);
            }
        }

        public static bool BoolSetting
        {
            get
            {
                return AppSettings.GetValueOrDefault("bool_setting", false, FileName);
            }
            set
            {
                AppSettings.AddOrUpdateValue("bool_setting", value, FileName);
            }
        }

		private const string txt_MinRateyKey = "txt_MinRate_Key";
		private static readonly double txt_MinRateDefault = 0.0;
		public static double txt_MinRate
		{
			get => AppSettings.GetValueOrDefault(txt_MinRateyKey, txt_MinRateDefault);
			set => AppSettings.AddOrUpdateValue(txt_MinRateyKey, value);
		}

		public static string StringSetting
        {
            get
            {
                return AppSettings.GetValueOrDefault(SettingsKey, SettingsDefault, FileName);
            }
            set
            {
                //if value has changed then save it!
                AppSettings.AddOrUpdateValue(SettingsKey, value, FileName);
            }
        }

        public static void Remove(string key)
        {
            AppSettings.Remove(key, FileName);
        }

        public static void Clear()
        {
            AppSettings.Clear(FileName);
        }

    }
}