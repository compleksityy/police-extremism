using System;
using System.IO;
using MelonLoader;
using Newtonsoft.Json;

namespace PoliceExtremism
{
    public class ModConfig
    {
        public bool EnableHardcoreAI { get; set; } = true;
        public float PoliceAccuracyMultiplier { get; set; } = 1.5f;
        public float PoliceDamageMultiplier { get; set; } = 1.2f;
        public float PoliceResponseTimeSeconds { get; set; } = 5.0f;
    }

    public static class ConfigManager
    {
        private static readonly string ConfigPath = Path.Combine(MelonUtils.UserDataDirectory, "PoliceExtremismConfig.json");
        public static ModConfig Current { get; private set; } = new ModConfig();

        public static void Load()
        {
            try
            {
                if (!File.Exists(ConfigPath))
                {
                    Save();
                    return;
                }

                string json = File.ReadAllText(ConfigPath);
                Current = JsonConvert.DeserializeObject<ModConfig>(json) ?? new ModConfig();
                MelonLogger.Msg("Configuration loaded successfully.");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"Failed to load configuration: {ex.Message}");
                Current = new ModConfig();
            }
        }

        public static void Save()
        {
            try
            {
                string json = JsonConvert.SerializeObject(Current, Formatting.Indented);
                File.WriteAllText(ConfigPath, json);
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"Failed to save configuration: {ex.Message}");
            }
        }
    }
}
