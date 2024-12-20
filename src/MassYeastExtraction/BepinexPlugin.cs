using BepInEx;
using BepInEx.Logging;
using MassYeastExtraction.Settings;
using System.IO;
using System.Reflection;

namespace MassYeastExtraction
{
    [BepInPlugin(LCMPluginInfo.PLUGIN_GUID, LCMPluginInfo.PLUGIN_NAME, LCMPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        internal static ManualLogSource Log = null!;
        internal static MassYeastExtractionSettings Settings = null!;

        private void Awake()
        {
            Log = Logger;
            Log.LogInfo($"Plugin {LCMPluginInfo.PLUGIN_NAME} version {LCMPluginInfo.PLUGIN_VERSION} is loaded!");
            Log.LogInfo($"{Assembly.GetExecutingAssembly().Location.Substring(0, Assembly.GetExecutingAssembly().Location.Length - 23)}");
            string recipesPath = Path.Combine(Assembly.GetExecutingAssembly().Location.Substring(0, Assembly.GetExecutingAssembly().Location.Length - 23), "Recipes.json");
            Lavender.Lavender.AddCustomRecipesFromJson(recipesPath, LCMPluginInfo.PLUGIN_NAME);
        }
    }
}