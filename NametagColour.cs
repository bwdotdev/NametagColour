using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace NametagColour;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
[BepInProcess("REPO.exe")]
public class Plugin : BaseUnityPlugin
{
  internal static new ManualLogSource Logger;
  private static Harmony _hi;

  private void Awake()
  {
    Logger = base.Logger;
    Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");

    _hi = new Harmony(MyPluginInfo.PLUGIN_GUID);
    _hi.PatchAll();
  }

  private void OnDestroy()
  {
    _hi.UnpatchSelf();
  }
}
