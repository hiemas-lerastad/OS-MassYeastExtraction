using BepInEx.Configuration;

namespace MassYeastExtraction.Settings;

public class MassYeastExtractionSettings(ConfigFile config)
{
    public ConfigEntry<bool> MySettingsBool = config.Bind<bool>("SectionName", "MySettingsBool", true, "This is an example boolean setting!");
}
