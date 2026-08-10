using System;
using BepInEx;

namespace SceneLoader
{
    [BepInPlugin("SceneLoader", "SceneLoader", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            Logger.LogInfo("Plugin SceneLoader is loaded!!!");
        }
    }
}
