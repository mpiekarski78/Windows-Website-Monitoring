using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Website_Monitoring.Library {
    public static class ConfigManager {
        public static Dictionary<string, string> GetSectionSettings(CustomConfigSections customConfigSection) {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = ((AppSettingsSection)configFile.GetSection(customConfigSection.ToString())).Settings;

            return settings.AllKeys.ToDictionary(key => key, key => settings[key].Value);
        }

        public static void AddSetting(CustomConfigSections customConfigSection, string settingName, string settingValue) {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = ((AppSettingsSection)configFile.GetSection(customConfigSection.ToString())).Settings;

            settings.Add(settingName, settingValue);

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }

        public static void RemoveSetting(CustomConfigSections customConfigSection, string settingName) {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = ((AppSettingsSection)configFile.GetSection(customConfigSection.ToString())).Settings;

            settings.Remove(settingName);

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }
    }
}
