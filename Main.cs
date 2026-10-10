using MelonLoader;
using UnityEngine;

namespace PoliceExtremism
{
    public class Main : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("Initializing Police Extremism Mod...");
            ConfigManager.Load();
            MelonLogger.Msg("Police Extremism Mod by Compleksity successfully initialized!");
        }

        public override void OnUpdate()
        {
            if (ConfigManager.Current.EnableHardcoreAI)
            {
                // Core mod execution loop
            }
        }
    }
}
