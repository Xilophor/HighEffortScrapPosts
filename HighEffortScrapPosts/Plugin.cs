using BepInEx;
using BepInEx.Logging;

namespace HighEffortScrapPosts;

[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    private void Awake()
    {
        Instance = this;
        Logger = base.Logger;
        
        
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }

    internal static Plugin Instance;
    internal new static ManualLogSource Logger;
}