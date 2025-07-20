using HarmonyLib;

namespace NametagColour.Patches;

[HarmonyPatch(typeof(MenuPlayerListed), "Update")]
public class MenuPlayerPatch
{
  static void Postfix(MenuPlayerListed __instance)
  {
    var player = __instance.playerAvatar;

    __instance.playerName.color = player.playerAvatarVisuals.color;
    __instance.playerName.alpha = player.voiceChat.isTalking ? 1f : 0.5f;
  }
}
