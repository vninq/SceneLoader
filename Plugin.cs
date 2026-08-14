using System;
using BepInEx;

namespace SceneLoader;
[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
 {
    private void Awake()
    {
        Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_NAME} is loaded!");
    }
}
