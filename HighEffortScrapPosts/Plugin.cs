using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace HighEffortScrapPosts;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    private void Awake()
    {
        Instance = this;
        Logger = base.Logger;
        
        Logger.LogDebug("Loading Assets...");
        
        LoadAllAssets();
        
        Assets.Do(asset => Logger.LogDebug(asset.name));
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }

    private void LoadAllAssets()
    {
        var resourceNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();

        resourceNames.Do(name => Logger.LogDebug(name));
        
        var assetBundles = resourceNames
            .Where(i => i.StartsWith("HighEffortScrapPosts.assets"))
            .Select(i => AssetBundle.LoadFromStream(Assembly
                .GetExecutingAssembly().GetManifestResourceStream(i)))
            .ToList();

        Assets = assetBundles.SelectMany(i => i.LoadAllAssets()).ToList();
    }

    internal static Plugin Instance; 
    internal new static ManualLogSource Logger;

    internal static List<Object> Assets;
}