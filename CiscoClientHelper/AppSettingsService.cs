using CiscoClientHelper.Models;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace CiscoClientHelper
{
    public class AppSettingsService
    {
        private AppSettings currentSettings;
        private readonly ISerializer serializer;
        private readonly IDeserializer deserializer;
        private static string DirectoryPath => Directory.GetCurrentDirectory();
        private const string Filename = "settings.yml";
        private static string SettingsFilePath => Path.Combine(DirectoryPath, Filename);

        public AppSettingsService()
        {
            serializer = new SerializerBuilder().WithNamingConvention(PascalCaseNamingConvention.Instance).Build();
            deserializer = new DeserializerBuilder().WithNamingConvention(PascalCaseNamingConvention.Instance).Build();
        }

        public AppSettings CurrentSettings => currentSettings;

        public void TryLoadSettings()
        {
            var settingsFromFile = File.ReadAllText(SettingsFilePath);
            if (string.IsNullOrEmpty(settingsFromFile))
            {
                throw new Exception();
            }

            var settings = deserializer.Deserialize<AppSettings>(settingsFromFile);
            currentSettings = settings;
        }

        public void TrySaveSettings()
        {
            var settingsToSave = serializer.Serialize(currentSettings);

            if(settingsToSave == null)
            {
                throw new Exception();
            }
            File.WriteAllText(SettingsFilePath, settingsToSave);
        }

        public void UpdateSettings(AppSettings newSettings)
        {
            currentSettings = newSettings;
        }

        private void CreateDefaultSettings()
        { 
            var defaultSettings = new AppSettings();
            currentSettings = defaultSettings;
            TrySaveSettings();
        }

        public void InitializeSettings()
        {
            if (!File.Exists(SettingsFilePath))
            {
                CreateDefaultSettings();
                return;
            }

            TryLoadSettings();
        }
    }
}
