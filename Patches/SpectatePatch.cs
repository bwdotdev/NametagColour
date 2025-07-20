using HarmonyLib;

namespace NametagColour.Patches;

[HarmonyPatch(typeof(SpectateNameUI), "SetName")]
public class SpectatePatch
{
  static void Postfix(SpectateNameUI __instance, string name)
  {
    var player = GameDirector.instance.PlayerList.Find(x => x.playerName == name);

    __instance.Text.color = player.playerAvatarVisuals.color;
    __instance.Text.alpha = player.voiceChat.isTalking ? 1f : 0.5f;
  }
}
