using HarmonyLib;
using UnityEngine;

[HarmonyPatch(typeof(WorldSpaceUIPlayerName), "Update")]
public class WorldUIPatch
{
  static void Postfix(WorldSpaceUIPlayerName __instance)
  {
    var text = __instance.text;
    var player = __instance.playerAvatar;

    if (text == null || player?.playerAvatarVisuals == null) return;

    Color currentColor = text.color;
    Color desiredRGB = player.playerAvatarVisuals.color;

    text.color = new Color(desiredRGB.r, desiredRGB.g, desiredRGB.b, currentColor.a);
  }
}