using HarmonyLib;
using UnityEngine;

namespace NametagColour.Patches;

[HarmonyPatch(typeof(WorldSpaceUIPlayerName), "Update")]
public class WorldUIPatch
{
  static void Postfix(WorldSpaceUIPlayerName __instance)
  {
    var text = __instance.text;
    var player = __instance.playerAvatar;

    if (text == null || player?.playerAvatarVisuals == null) return;

    Color currentColor = text.color;
    Color playerColor = player.playerAvatarVisuals.color;

    text.color = new Color(playerColor.r, playerColor.g, playerColor.b, currentColor.a);
  }
}
